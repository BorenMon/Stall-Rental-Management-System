using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;

namespace Stall_Rental_Management_System.Repositories
{
    public class InvoiceRepository : BaseRepository, IInvoiceRepository
    {
        // Constructor
        public InvoiceRepository()
        {
            connectionString = DatabaseUtil.GetConnectionString();
        }
        
        // Methods
        public void InsertOrUpdate(InvoiceModel model, int primaryKey)
        {
            // using (var connection = new SqlConnection(connectionString))
            // using (var command = new SqlCommand("spInsertOrUpdateStaff", connection))
            // {
            //     command.CommandType = CommandType.StoredProcedure;
            //     command.Parameters.Add("@staff_id", SqlDbType.Int).Value = primaryKey;
            //     command.Parameters.Add("@last_name_kh", SqlDbType.NVarChar).Value = model.LastNameKh;
            //     command.Parameters.Add("@first_name_kh", SqlDbType.NVarChar).Value = model.FirstNameKh;
            //     command.Parameters.Add("@last_name_en", SqlDbType.VarChar).Value = model.LastNameEn;
            //     command.Parameters.Add("@first_name_en", SqlDbType.VarChar).Value = model.FirstNameEn;
            //     command.Parameters.Add("@birth_date", SqlDbType.DateTime).Value = model.BirthDate;
            //     command.Parameters.Add("@gender", SqlDbType.VarChar).Value = model.Gender.ToString();
            //     command.Parameters.Add("@email", SqlDbType.VarChar).Value = model.Email;
            //     command.Parameters.Add("@position", SqlDbType.VarChar).Value = model.Position.ToString();
            //     command.Parameters.Add("@address", SqlDbType.VarChar).Value = model.Address;
            //     command.Parameters.Add("@phone_number", SqlDbType.VarChar).Value = model.PhoneNumber;
            //     command.Parameters.Add("@password", SqlDbType.VarChar).Value = model.Password;
            //     command.Parameters.Add("@profile_image_url", SqlDbType.VarChar).Value = model.ProfileImageUrl;
            //
            //     connection.Open();
            //     command.ExecuteNonQuery();
            // }
        }

        public void Delete(InvoiceModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spDeleteStaff", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@StaffID", SqlDbType.Int).Value = model.StaffId;
        
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<InvoiceModel> GetAll()
        {
            var list = new List<InvoiceModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM vStaffs ORDER BY StaffID ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var genderString = reader["Gender"].ToString();
                        Enum.TryParse(genderString, true, out Gender gender);
                        var positionString = reader["Position"].ToString();
                        Enum.TryParse(positionString, true, out StaffPosition position);
                        
                        var invoice = new InvoiceModel
                        {
                            // StaffId = (int)reader["StaffID"],
                            // ProfileImageUrl = reader["ProfileImageURL"].ToString(),
                            // LastNameKh = reader["LastNameKH"].ToString(),
                            // FirstNameKh = reader["FirstNameKH"].ToString(),
                            // LastNameEn = reader["LastNameEN"].ToString(),
                            // FirstNameEn = reader["FirstNameEN"].ToString(),
                            // BirthDate = (DateTime)reader["BirthDate"],
                            // Gender = gender,
                            // Email = reader["Email"].ToString(),
                            // Position = position,
                            // PhoneNumber = reader["PhoneNumber"].ToString(),
                            // Password = reader["Password"].ToString(),
                            // Address = reader["Address"].ToString()
                        };
                        list.Add(invoice);
                    }
                }
            }
                
            return list;
        }

        public IEnumerable<InvoiceModel> GetByValue(string value)
        {
            var list = new List<InvoiceModel>();
            var staffId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spGetStaffsByValue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = staffId;
                command.Parameters.Add("@name_en", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@name_kh", SqlDbType.NVarChar).Value = value;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var genderString = reader["Gender"].ToString();
                        Enum.TryParse(genderString, true, out Gender gender);
                        var positionString = reader["Position"].ToString();
                        Enum.TryParse(positionString, true, out StaffPosition position);

                        var invoice = new InvoiceModel
                        {
                            // StaffId = (int)reader["StaffID"],
                            // ProfileImageUrl = reader["ProfileImageURL"].ToString(),
                            // LastNameKh = reader["LastNameKH"].ToString(),
                            // FirstNameKh = reader["FirstNameKH"].ToString(),
                            // LastNameEn = reader["LastNameEN"].ToString(),
                            // FirstNameEn = reader["FirstNameEN"].ToString(),
                            // BirthDate = (DateTime)reader["BirthDate"],
                            // Gender = gender,
                            // Email = reader["Email"].ToString(),
                            // Position = position,
                            // PhoneNumber = reader["PhoneNumber"].ToString(),
                            // Password = reader["Password"].ToString(),
                            // Address = reader["Address"].ToString()
                        };
                        list.Add(invoice);
                    }
                }
            }

            return list;
        }
    }
}

