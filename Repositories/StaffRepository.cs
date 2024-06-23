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
    public class StaffRepository : BaseRepository, IStaffRepository
    {
        // Constructor
        public StaffRepository()
        {
            this.connectionString = DatabaseUtil.GetConnectionString();
        }
        
        // Methods
        public void InsertOrUpdate(StaffModel staffModel, int primaryKey, bool isPasswordChanged)
        {
            if (isPasswordChanged)
            {
                staffModel.Password = AuthHelper.HashPassword(staffModel.Password);
            }

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("InsertOrUpdateStaff", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@staff_id", SqlDbType.Int).Value = primaryKey;
                command.Parameters.Add("@last_name_kh", SqlDbType.NVarChar).Value = staffModel.LastNameKh;
                command.Parameters.Add("@first_name_kh", SqlDbType.NVarChar).Value = staffModel.FirstNameKh;
                command.Parameters.Add("@last_name_en", SqlDbType.VarChar).Value = staffModel.LastNameEn;
                command.Parameters.Add("@first_name_en", SqlDbType.VarChar).Value = staffModel.FirstNameEn;
                command.Parameters.Add("@birth_date", SqlDbType.DateTime).Value = staffModel.BirthDate;
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = staffModel.Gender.ToString();
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = staffModel.Email;
                command.Parameters.Add("@position", SqlDbType.VarChar).Value = staffModel.Position.ToString();
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = staffModel.Address;
                command.Parameters.Add("@phone_number", SqlDbType.VarChar).Value = staffModel.PhoneNumber;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = staffModel.Password;
                command.Parameters.Add("@profile_image_url", SqlDbType.VarChar).Value = staffModel.ProfileImageUrl;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(StaffModel staffModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from tbStaff where StaffID = @staff_id";
                command.Parameters.Add("@staff_id", SqlDbType.Int).Value = staffModel.StaffId;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<StaffModel> GetAll()
        {
            var staffList = new List<StaffModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tbStaff ORDER BY StaffID ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var genderString = reader["Gender"].ToString();
                        Enum.TryParse(genderString, true, out Gender gender);
                        var positionString = reader["Position"].ToString();
                        Enum.TryParse(positionString, true, out StaffPosition position);
                        
                        var staff = new StaffModel
                        {
                            StaffId = (int)reader["StaffID"],
                            ProfileImageUrl = reader["ProfileImageURL"].ToString(),
                            LastNameKh = reader["LastNameKH"].ToString(),
                            FirstNameKh = reader["FirstNameKH"].ToString(),
                            LastNameEn = reader["LastNameEN"].ToString(),
                            FirstNameEn = reader["FirstNameEN"].ToString(),
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = gender,
                            Email = reader["Email"].ToString(),
                            Position = position,
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Password = reader["Password"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                        staffList.Add(staff);
                    }
                }
            }
                
            return staffList;
        }

        public IEnumerable<StaffModel> GetByValue(string value)
        {
            var staffList = new List<StaffModel>();
            var staffId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from tbStaff 
                        where StaffID = @id 
                        or LastNameEN + ' ' + FirstNameEN like @name_en + '%'
                        or LastNameKH + ' ' + FirstNameKH like @name_kh + '%'
                        or Position like @name_en + '%'
                        or PhoneNumber like @name_en + '%'
                        order by StaffID desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = staffId;
                command.Parameters.Add("@name_en", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@name_kh", SqlDbType.NVarChar).Value = value;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var genderString = reader["Gender"].ToString();
                        Enum.TryParse(genderString, true, out Gender gender);
                        var positionString = reader["Position"].ToString();
                        Enum.TryParse(positionString, true, out StaffPosition position);
                        
                        var staff = new StaffModel
                        {
                            StaffId = (int)reader["StaffID"],
                            ProfileImageUrl = reader["ProfileImageURL"].ToString(),
                            LastNameKh = reader["LastNameKH"].ToString(),
                            FirstNameKh = reader["FirstNameKH"].ToString(),
                            LastNameEn = reader["LastNameEN"].ToString(),
                            FirstNameEn = reader["FirstNameEN"].ToString(),
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = gender,
                            Email = reader["Email"].ToString(),
                            Position = position,
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Password = reader["Password"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                        staffList.Add(staff);
                    }
                }
            }
                
            return staffList;
        }
    }
}