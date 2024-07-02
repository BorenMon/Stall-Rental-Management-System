using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Repositories
{
    internal class ContractRepository : IContractRepository
    {
        private readonly SqlConnection _sqlConnection;
        //constructor
        public ContractRepository() {
            try
            {
                _sqlConnection = DatabaseUtil.GetConnection();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, @"SQL Connection", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Add(ContractModel contractModel)
        {
            OpenDatabaseConnection();
            const string sql = @"INSERT INTO tbContract
                         (FileURL, Code, Status, StartDate, EndDate, StallID, VendorID, StaffID)
                          VALUES(
                          @fileUrl, @contractCode, @status,
                          @startDate, @endDate, @stallID,
                          @vendorID, @staffID)";
            
            using (var sqlCommand = new SqlCommand(sql, _sqlConnection))
            {
                sqlCommand.Parameters.Add("@fileUrl", SqlDbType.NVarChar).Value = contractModel.FileUrl;
                sqlCommand.Parameters.Add("@contractCode", SqlDbType.VarChar).Value = contractModel.Code;
                sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = contractModel.Status.ToString();
                sqlCommand.Parameters.Add("@startDate", SqlDbType.DateTime).Value = contractModel.StartDate;
                sqlCommand.Parameters.Add("@endDate", SqlDbType.DateTime).Value = contractModel.EndDate;
                sqlCommand.Parameters.Add("@stallID", SqlDbType.Int).Value = contractModel.StallId;
                sqlCommand.Parameters.Add("@vendorID", SqlDbType.Int).Value = contractModel.VendorId;
                sqlCommand.Parameters.Add("@staffID", SqlDbType.Int).Value = contractModel.StaffId;

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    
                    MessageBox.Show(@"Contract has been created successfully",
                        @"Success",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            _sqlConnection.Close();
        }

        public IEnumerable<ContractModel> GetAll()
        {
            var contractList = new List<ContractModel>();
            using (var sqlCommand = new SqlCommand())
            {
                OpenDatabaseConnection();

                // 
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbContract ORDER BY ContractID DESC";
                //
                using(var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contractString = reader["Status"].ToString();
                        Enum.TryParse(contractString, true, out ContractStatus status);
                        
                        var contractModel = new ContractModel
                        {
                            ContractId = (int) reader[0],
                            FileUrl = (string)reader[1],
                            Code = (string)reader[2],
                            Status = status,
                            StartDate = (DateTime)reader[4],
                            EndDate = (DateTime)reader[5],
                            StallId = (int)reader[6],
                            VendorId = (int)reader[7],
                            StaffId = (int)reader[8]
                        };
                        contractList.Add(contractModel);
                    }
                }
            }
            _sqlConnection.Close();
            return contractList;
        }

        public IEnumerable<int> GetAllStallID()
        {
            var allStallIDs = new List<int>();
            using (var sqlConnection = new SqlConnection(DatabaseUtil.GetConnectionString()))
            using (var sqlCommand = new SqlCommand("SELECT StallID FROM tbStall WHERE Status = 'AVAILABLE'", sqlConnection))
            {
                sqlConnection.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allStallIDs.Add(reader.GetInt32(0)); // Use GetInt32 method to get the int value
                    }
                }
            }
            return allStallIDs;
        }

        public IEnumerable<int> GetAllVendorID()
        {
            var allVendorIDs = new List<int>();
            using (var sqlConnection = new SqlConnection(DatabaseUtil.GetConnectionString()))
            using (var sqlCommand = new SqlCommand("SELECT VendorID FROM tbVendor", sqlConnection))
            {
                sqlConnection.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allVendorIDs.Add(reader.GetInt32(0));
                    }
                }
            }
            return allVendorIDs;
        }

        public IEnumerable<ContractModel> GetByID(string id)
        {
            var contractList = new List<ContractModel>();
            var contractId = int.TryParse(id, out _) ? Convert.ToInt32(id):0;
            using (var sqlCommand = new SqlCommand())
            {
                _sqlConnection.Open();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbContract WHERE ContractID=@id";
                
                //
                sqlCommand.Parameters.Add("@id",SqlDbType.Int).Value = contractId;
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contractString = reader["Status"].ToString();
                        Enum.TryParse(contractString, true, out ContractStatus status);
                        
                        var contractModel = new ContractModel
                        {
                            ContractId = (int)reader[0],
                            FileUrl = (string)reader[1],
                            Code = (string)reader[2],
                            Status = status,
                            StartDate = (DateTime)reader[4],
                            EndDate = (DateTime)reader[5],
                            StallId = (int)reader[6],
                            VendorId = (int)reader[7],
                            StaffId = (int)reader[8]
                        };
                        contractList.Add(contractModel);
                    }
                }
            }
            _sqlConnection.Close();
            return contractList;
        }

        public void Update(ContractModel contractModel)
        {
            Console.Write(contractModel.Status);
            OpenDatabaseConnection();
            //
            // Create a command object
            using (SqlCommand cmd = new SqlCommand("UpdateContract", _sqlConnection))
            {
                // Specify that the command is a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Add the parameters
                cmd.Parameters.Add(new SqlParameter("@FileURL", contractModel.FileUrl));
                cmd.Parameters.Add(new SqlParameter("@Code", contractModel.Code));
                cmd.Parameters.Add(new SqlParameter("@Status", contractModel.Status.ToString()));
                cmd.Parameters.Add(new SqlParameter("@StartDate", contractModel.StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", contractModel.EndDate));
                cmd.Parameters.Add(new SqlParameter("@StallID", contractModel.StallId));
                cmd.Parameters.Add(new SqlParameter("@VendorID", contractModel.VendorId));
                cmd.Parameters.Add(new SqlParameter("@StaffID", contractModel.StaffId));
                cmd.Parameters.Add(new SqlParameter("@ContractID", contractModel.ContractId));

                // Execute the command
                cmd.ExecuteNonQuery();
            }
            _sqlConnection.Close();
        }
        //
        private void OpenDatabaseConnection()
        {
            try
            {
                _sqlConnection.Open();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    @"Error", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);
            }
        }
    }
}
