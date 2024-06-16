using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;

namespace Stall_Rental_Management_System.Repositories
{
    public class StaffRepository : BaseRepository, IStaffRepository
    {
        // Constructor
        public StaffRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        // Methods
        public void Add(StaffModel staffModel)
        {
            
        }

        public void Edit(StaffModel staffModel)
        {
            
        }

        public void Delete(StaffModel staffModel)
        {
            
        }

        public IEnumerable<StaffModel> GetAll()
        {
            var staffList = new List<StaffModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from tbStaff order by StaffID desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var staff = new StaffModel
                        {
                            StaffId = (int)reader[0],
                            FullNameKh = reader[4] + " " + reader[5],
                            FullNameEn = reader[2] + " " + reader[3],
                            Position = reader[9].ToString(),
                            PhoneNumber = reader[10].ToString(),
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
                        var staff = new StaffModel
                        {
                            StaffId = (int)reader[0],
                            FullNameKh = reader[4] + " " + reader[5],
                            FullNameEn = reader[2] + " " + reader[3],
                            Position = reader[9].ToString(),
                            PhoneNumber = reader[10].ToString(),
                        };
                        staffList.Add(staff);
                    }
                }
            }
                
            return staffList;
        }
    }
}