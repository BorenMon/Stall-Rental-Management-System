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
    public class StallRepository: BaseRepository, IStallRepository
    {
        // Constructor
        public StallRepository()
        {
            this.connectionString = DatabaseUtil.GetConnectionString();
        }
        
        // Methods
        public void InsertOrUpdate(StallModel stallModel, int primaryKey)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spInsertOrUpdateStall", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@stall_id", SqlDbType.Int).Value = primaryKey;
                command.Parameters.Add("@code", SqlDbType.VarChar).Value = stallModel.Code;
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = stallModel.Status;
                command.Parameters.Add("@type", SqlDbType.VarChar).Value = stallModel.Type;
                command.Parameters.Add("@size", SqlDbType.Float).Value = stallModel.Size;
                command.Parameters.Add("@monthly_fee", SqlDbType.Money).Value = stallModel.MonthlyFee;
                command.Parameters.Add("@location", SqlDbType.VarChar).Value = stallModel.Location;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(StallModel stallModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spDeleteStall", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@StallID", SqlDbType.Int).Value = stallModel.StallId;
        
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<StallModel> GetAll()
        {
            var stallList = new List<StallModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tbStall ORDER BY StallID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var statusString = reader["Status"].ToString();
                        Enum.TryParse(statusString, true, out StallStatus status);

                        float.TryParse(reader["size"].ToString(), out var size);

                        var stall = new StallModel
                        {
                            StallId = (int)reader["StallID"],
                            Code = reader["Code"].ToString(),
                            Status = status,
                            Type = reader["Type"].ToString(),
                            Size = size,
                            MonthlyFee = (decimal)reader["MonthlyFee"],
                            Location = reader["Location"].ToString() // Assuming this should be the Location column value
                        };
                        stallList.Add(stall);
                    }
                }
            }
    
            return stallList;
        }

        public IEnumerable<StallModel> GetByCode(string code)
        {
            var stallList = new List<StallModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spGetStallsByValue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@code", SqlDbType.NVarChar).Value = code;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var statusString = reader["Status"].ToString();
                        Enum.TryParse(statusString, true, out StallStatus status);

                        float.TryParse(reader["size"].ToString(), out var size);

                        var stall = new StallModel
                        {
                            StallId = (int)reader["StallID"],
                            Code = reader["Code"].ToString(),
                            Status = status,
                            Type = reader["Type"].ToString(),
                            Size = size,
                            MonthlyFee = (decimal)reader["MonthlyFee"],
                            Location = reader["Location"].ToString() // Assuming this should be the Location column value
                        };
                        stallList.Add(stall);
                    }
                }
            }

            return stallList;
        }


        // Images
        public IEnumerable<StallImageModel> GetImagesByStallId(int stallId)
        {
            var images = new List<StallImageModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM tbStallImage WHERE StallID = @StallID", connection))
            {
                command.Parameters.AddWithValue("@StallID", stallId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        images.Add(new StallImageModel
                        {
                            StallImageID = (int)reader["StallImageID"],
                            URL = reader["URL"].ToString(),
                            FileName = reader["FileName"].ToString(),
                            StallID = (int)reader["StallID"]
                        });
                    }
                }
            }
            return images;
        }

        public void AddImage(StallImageModel image)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("INSERT INTO tbStallImage (URL, FileName, StallID) VALUES (@URL, @FileName, @StallID)", connection))
            {
                command.Parameters.AddWithValue("@URL", image.URL);
                command.Parameters.AddWithValue("@FileName", image.FileName);
                command.Parameters.AddWithValue("@StallID", image.StallID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveImage(int imageId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("DELETE FROM tbStallImage WHERE StallImageID = @StallImageID", connection))
            {
                command.Parameters.AddWithValue("@StallImageID", imageId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}