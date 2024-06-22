using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stall_Rental_Management_System.Enums;
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
        public void Add(StaffModel staffModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into tbStaff values (@last_name_kh)";
                command.Parameters.Add("@last_name_kh", SqlDbType.VarChar).Value = staffModel.LastNameKh;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(StaffModel staffModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update tbStaff set LastNameKH = @last_name_kh where StaffID = @staff_id";
                command.Parameters.Add("@last_name_kh", SqlDbType.VarChar).Value = staffModel.LastNameKh;
                command.Parameters.Add("@staff_id", SqlDbType.Int).Value = staffModel.StaffId;
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
                        Console.Write(genderString);
                        Enum.TryParse(genderString, true, out Gender gender);
                        
                        var staff = new StaffModel
                        {
                            StaffId = (int)reader["StaffID"],
                            FullNameKh = reader["LastNameKH"] + " " + reader["FirstNameKH"],
                            FullNameEn = reader["LastNameEN"] + " " + reader["FirstNameEN"],
                            LastNameKh = reader["LastNameKH"].ToString(),
                            FirstNameKh = reader["FirstNameKH"].ToString(),
                            LastNameEn = reader["LastNameEN"].ToString(),
                            FirstNameEn = reader["FirstNameEN"].ToString(),
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = gender,
                            Email = reader["Email"].ToString(),
                            Position = reader["Position"].ToString(),
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
                        
                        var staff = new StaffModel
                        {
                            StaffId = (int)reader["StaffID"],
                            FullNameKh = reader["LastNameKH"] + " " + reader["FirstNameKH"],
                            FullNameEn = reader["LastNameEN"] + " " + reader["FirstNameEN"],
                            LastNameKh = reader["LastNameKH"].ToString(),
                            FirstNameKh = reader["FirstNameKH"].ToString(),
                            LastNameEn = reader["LastNameEN"].ToString(),
                            FirstNameEn = reader["FirstNameEN"].ToString(),
                            BirthDate = (DateTime)reader["BirthDate"],
                            Gender = gender,
                            Email = reader["Email"].ToString(),
                            Position = reader["Position"].ToString(),
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