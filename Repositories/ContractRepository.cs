using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Repositories
{
    internal class ContractRepository : IContractRepository
    {
        private SqlConnection sqlConnection;
        //consructor
        public ContractRepository() {
            try
            {
                sqlConnection = DatabaseUtil.GetConn();
            }catch (Exception ex) {
                MessageBox.Show(ex.Message, "SQL Connection", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Add(ContractModel contractModel)
        {
            openDatabaseConnection();
            string sql = @"INSERT INTO tbContract
                         (FileUrl,Code, Status, StartDate, EndDate, StallID, VendorID, StaffID)
                          VALUES(
                          @fileUrl, @contractCode, @status,
                          @startDate, @endDate, @stallID,
                          @vendorID, @staffID)";
            using (var sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                //MessageBox.Show(contractModel.FileUrl);
                sqlCommand.Parameters.AddWithValue("@fileUrl", contractModel.FileUrl);
                sqlCommand.Parameters.AddWithValue("@contractCode", contractModel.Code);
                sqlCommand.Parameters.AddWithValue("@status", contractModel.Status);
                sqlCommand.Parameters.AddWithValue("@startDate", contractModel.StartDate.Date);
                sqlCommand.Parameters.AddWithValue("@endDate", contractModel.EndDate.Date);
                sqlCommand.Parameters.AddWithValue("@stallID", contractModel.StallId);
                sqlCommand.Parameters.AddWithValue("@vendorID", contractModel.VendorId);
                sqlCommand.Parameters.AddWithValue("@staffID", contractModel.StaffId);
                //
                try
                {
                    int rowAffected = sqlCommand.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Contract has been created successfully",
                            "Success",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot create new contract",
                            "Error", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);
                }

            }
            sqlConnection.Close();
        }

        public IEnumerable<ContractModel> GetAll()
        {
            var contractList = new List<ContractModel>();
            using (var sqlCommand = new SqlCommand())
            {
                openDatabaseConnection();

                //
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbContract 
                                           WHERE Status = 'available'
                                           ORDER BY ContractID DESC ";
                //
                using(var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contractModel = new ContractModel();
                        contractModel.Id = (int) reader[0];
                        contractModel.FileUrl = (string)reader[1];
                        contractModel.Code = (string)reader[2];
                        contractModel.Status = (string)reader[3];
                        contractModel.StartDate = (DateTime)reader[4];
                        contractModel.EndDate = (DateTime)reader[5];
                        contractModel.StallId = (int)reader[6];
                        contractModel.VendorId = (int)reader[7];
                        contractModel.StaffId = (int)reader[8];
                        contractList.Add(contractModel);
                    }
                }
            }
            sqlConnection.Close();
            return contractList;
        }

        public IEnumerable<int> GetAllStallID()
        {
            var allStallIDs = new List<int>();
            using (var sqlCommand = new SqlCommand())
            {
                openDatabaseConnection();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT StallID FROM tbStall";
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allStallIDs.Add((int)reader[0]);
                    }
                }
            }
            //MessageBox.Show(allStallIDs.Count().ToString());
            sqlConnection.Close ();
            return allStallIDs;
        }
        public IEnumerable<int> GetAllVendorID()
        {
            openDatabaseConnection ();
            var allVendorIDs = new List<int>();
            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT VendorID FROM tbVendor";
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allVendorIDs.Add((int)reader[0]);
                    }
                }
            }
            sqlConnection.Close ();
            //MessageBox.Show(allStallIDs.Count().ToString());
            return allVendorIDs;

        }

        public IEnumerable<ContractModel> GetByID(string id)
        {
            //MessageBox.Show("Empty: " + string.IsNullOrWhiteSpace(id).ToString());
            //MessageBox.Show( "ID : " + id);
            var contractList = new List<ContractModel>();
            int contractID = int.TryParse(id, out _) ? Convert.ToInt32(id):0;
            //using (var connectionSQLSever = DatabaseUtil.GetConn())
            using (var sqlCommand = new SqlCommand())
            {
                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbContract WHERE ContractID=@id
                                           AND Status = 'available'";
                
                //
                sqlCommand.Parameters.Add("@id",SqlDbType.Int).Value = contractID;
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contractModel = new ContractModel();
                        contractModel.Id = (int)reader[0];
                        contractModel.FileUrl = (string)reader[1];
                        contractModel.Code = (string)reader[2];
                        contractModel.Status = (string)reader[3];
                        contractModel.StartDate = (DateTime)reader[4];
                        contractModel.EndDate = (DateTime)reader[5];
                        contractModel.StallId = (int)reader[6];
                        contractModel.VendorId = (int)reader[7];
                        contractModel.StaffId = (int)reader[8];
                        contractList.Add(contractModel);
                    }
                }
            }
            sqlConnection.Close();
            return contractList;
        }

        public void Update(ContractModel contractModel)
        {
            openDatabaseConnection();
            //
            // Create a command object
            using (SqlCommand cmd = new SqlCommand("UpdateContract", sqlConnection))
            {
                // Specify that the command is a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Add the parameters
                cmd.Parameters.Add(new SqlParameter("@FileURL", contractModel.FileUrl));
                cmd.Parameters.Add(new SqlParameter("@Code", contractModel.Code));
                cmd.Parameters.Add(new SqlParameter("@Status", contractModel.Status));
                cmd.Parameters.Add(new SqlParameter("@StartDate", contractModel.StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", contractModel.EndDate));
                cmd.Parameters.Add(new SqlParameter("@StallID", contractModel.StallId));
                cmd.Parameters.Add(new SqlParameter("@VendorID", contractModel.VendorId));
                cmd.Parameters.Add(new SqlParameter("@StaffID", contractModel.StaffId));
                cmd.Parameters.Add(new SqlParameter("@ContractID", contractModel.Id));

                // Execute the command
                cmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
        //
        private void openDatabaseConnection()
        {
            try
            {
                sqlConnection.Open();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);
            }
        }
    }
}
