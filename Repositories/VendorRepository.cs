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
    public class VendorRepository : BaseRepository, IVendorRepository
    {
        // Constructor
        public VendorRepository()
        {
            this.connectionString = DatabaseUtil.GetConnectionString();
        }
        
        // Methods
        public void InsertOrUpdate(VendorModel vendorModel, int primaryKey, bool isPasswordChanged)
        {
            if (isPasswordChanged)
            {
                vendorModel.Password = AuthHelper.HashPassword(vendorModel.Password);
            }

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spInsertOrUpdateVendor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@vendor_id", SqlDbType.Int).Value = primaryKey;
                command.Parameters.Add("@last_name_kh", SqlDbType.NVarChar).Value = vendorModel.LastNameKh;
                command.Parameters.Add("@first_name_kh", SqlDbType.NVarChar).Value = vendorModel.FirstNameKh;
                command.Parameters.Add("@last_name_en", SqlDbType.VarChar).Value = vendorModel.LastNameEn;
                command.Parameters.Add("@first_name_en", SqlDbType.VarChar).Value = vendorModel.FirstNameEn;
                command.Parameters.Add("@birth_date", SqlDbType.DateTime).Value = vendorModel.BirthDate;
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = vendorModel.Gender.ToString();
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = vendorModel.Email;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = vendorModel.Address;
                command.Parameters.Add("@phone_number", SqlDbType.VarChar).Value = vendorModel.PhoneNumber;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = vendorModel.Password;
                command.Parameters.Add("@profile_image_url", SqlDbType.VarChar).Value = vendorModel.ProfileImageUrl;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(VendorModel vendorModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spDeleteVendor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@VendorID", SqlDbType.Int).Value = vendorModel.VendorId;
        
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<VendorModel> GetAll()
        {
            var vendorList = new List<VendorModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tbVendor ORDER BY VendorID ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var genderString = reader["Gender"].ToString();
                        Enum.TryParse(genderString, true, out Gender gender);
                        
                        var vendor = new VendorModel
                        {
                            VendorId = (int)reader["VendorID"],
                            ProfileImageUrl = reader["ProfileImageURL"].ToString(),
                            LastNameKh = reader["LastNameKH"].ToString(),
                            FirstNameKh = reader["FirstNameKH"].ToString(),
                            LastNameEn = reader["LastNameEN"].ToString(),
                            FirstNameEn = reader["FirstNameEN"].ToString(),
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = gender,
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Password = reader["Password"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                        vendorList.Add(vendor);
                    }
                }
            }
                
            return vendorList;
        }

        public IEnumerable<VendorModel> GetByValue(string value)
        {
            var vendorList = new List<VendorModel>();
            var vendorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spGetVendorsByValue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = vendorId;
                command.Parameters.Add("@name_en", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@name_kh", SqlDbType.NVarChar).Value = value;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var genderString = reader["Gender"].ToString();
                        Enum.TryParse(genderString, true, out Gender gender);

                        var vendor = new VendorModel
                        {
                            VendorId = (int)reader["StaffID"],
                            ProfileImageUrl = reader["ProfileImageURL"].ToString(),
                            LastNameKh = reader["LastNameKH"].ToString(),
                            FirstNameKh = reader["FirstNameKH"].ToString(),
                            LastNameEn = reader["LastNameEN"].ToString(),
                            FirstNameEn = reader["FirstNameEN"].ToString(),
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = gender,
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Password = reader["Password"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                        vendorList.Add(vendor);
                    }
                }
            }

            return vendorList;
        }
    }
}