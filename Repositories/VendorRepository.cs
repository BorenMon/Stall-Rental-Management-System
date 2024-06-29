using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stall_Rental_Management_System.Repositories
{
    internal class VendorRepository : IVendorRepository
    {
        private SqlConnection sqlConnection;
        public VendorRepository() {
            try
            {
                sqlConnection = DatabaseUtil.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void openDatabaseConnection()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);
            }
        }
        public void Add(VendorModel vendorModel)
        {
            if(vendorModel.ProfileUrl == null)
            {
                vendorModel.ProfileUrl = "google.com";
            }
            openDatabaseConnection(); 
            string sql = @"INSERT INTO tbVendor
                   (ProfileImageURL, LastNameEN, FirstNameEN, Gender,
                    Email, PhoneNumber, Password, Address)
                   VALUES (
                   @profileUrl, @lastName, @firstName,
                   @gender, @email, @phone,
                   @pass, @address)";
            using (var sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@profileUrl", vendorModel.ProfileUrl);
                sqlCommand.Parameters.AddWithValue("@lastName", vendorModel.LastNameEN);
                sqlCommand.Parameters.AddWithValue("@firstName", vendorModel.FirstNameEN);
                sqlCommand.Parameters.AddWithValue("@gender", vendorModel.Gender);
                sqlCommand.Parameters.AddWithValue("@email", vendorModel.Email);
                sqlCommand.Parameters.AddWithValue("@phone", vendorModel.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@pass", vendorModel.Password);
                sqlCommand.Parameters.AddWithValue("@address", vendorModel.Address);

                try
                {
                    int rowAffected = sqlCommand.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Vendor has been created successfully",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot create new vendor",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            sqlConnection.Close();
        }

        public IEnumerable<VendorModel> GetAll()
        {
            var vendorList = new List<VendorModel>();
            using (var sqlCommand = new SqlCommand())
            {
                openDatabaseConnection();
                // get all vendors
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbVendor 
                                           ORDER BY VendorID DESC
                                           ";

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var vendorModel = new VendorModel();
                        vendorModel.VendorID = (int)reader[0];
                        vendorModel.ProfileUrl = (string)reader[1];
                        vendorModel.LastNameEN = (string)reader[2];
                        vendorModel.FirstNameEN = (string)reader[3];
                        vendorModel.Gender = (string)reader[7];
                        vendorModel.Email = (string)reader[8];
                        vendorModel.PhoneNumber = (string)reader[9];
                        vendorModel.Password = (string)reader[10];
                        vendorModel.Address = (string)reader[11];

                        vendorList.Add(vendorModel);
                    }
                }

            }
            sqlConnection.Close();
           return vendorList;
        }

        public IEnumerable<VendorModel> GetByID(int id)
        {
            openDatabaseConnection() ;
            List<VendorModel> vendorList = new List<VendorModel>();
            string sql = @"SELECT * FROM tbVendor WHERE VendorID = @id";
            //int vendorID = int.TryParse(id, out _) ? Convert.ToInt32(id) : 0;
            //using (var connectionSQLSever = DatabaseUtil.GetConn())
            using (var sqlCommand = new SqlCommand())
            {
                //sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = sql;

                //
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var vendorModel = new VendorModel();
                        vendorModel.VendorID = (int)reader[0];
                        vendorModel.ProfileUrl = (string)reader[1];
                        vendorModel.LastNameEN = (string)reader[2];
                        vendorModel.FirstNameEN = (string)reader[3];
                        vendorModel.Gender = (string)reader[7];
                        vendorModel.Email = (string)reader[8];
                        vendorModel.PhoneNumber = (string)reader[9];
                        vendorModel.Password = (string)reader[10];
                        vendorModel.Address = (string)reader[11];
                        vendorList.Add(vendorModel);
                    }
                }
            }
            sqlConnection.Close();
            return vendorList;
        }

        public void Update(VendorModel vendorModel)
        {
            // Define your stored procedure name
            string storedProcedureName = "UpdateVendor";
            openDatabaseConnection();
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@VendorID", vendorModel.VendorID);
                cmd.Parameters.AddWithValue("@ProfileImageUrl", vendorModel.ProfileUrl);
                cmd.Parameters.AddWithValue("@LastNameEN", vendorModel.LastNameEN);
                cmd.Parameters.AddWithValue("@FirstNameEN", vendorModel.FirstNameEN);
                cmd.Parameters.AddWithValue("@Email", vendorModel.Email);
                cmd.Parameters.AddWithValue("@Password", vendorModel.Password);
                cmd.Parameters.AddWithValue("@Gender", vendorModel.Gender);
                cmd.Parameters.AddWithValue("@Address", vendorModel.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", vendorModel.PhoneNumber);

                // Execute the command
                cmd.ExecuteNonQuery();

                // Inform the user
                MessageBox.Show("Vendor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlConnection.Close() ;
        }

        public void Delete(int id)
        {
            openDatabaseConnection();
            string deleteQuery = "DELETE FROM tbVendor WHERE VendorID = @RecordID";

            try
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@RecordID", id);
                    // Show confirmation dialog
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete vendor with ID {id}?",
                        "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }
    }
}
