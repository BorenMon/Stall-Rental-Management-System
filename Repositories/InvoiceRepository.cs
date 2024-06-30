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
    public class InvoiceRepository : BaseRepository, IInvoiceRepository
    {
        // Constructor
        public InvoiceRepository()
        {
            connectionString = DatabaseUtil.GetConnectionString();
        }
        
        // Methods
        public void InsertOrUpdate(InvoiceModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spInsertOrUpdateInvoice", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceID", model.InvoiceId);
                command.Parameters.AddWithValue("@InvoiceNo", model.InvoiceNo);
                command.Parameters.AddWithValue("@IssuedDate", model.IssuedDate);
                command.Parameters.AddWithValue("@RentFee", model.RentFee);
                command.Parameters.AddWithValue("@ElectricityCost", model.ElectricityCost);
                command.Parameters.AddWithValue("@WaterCost", model.WaterCost);
                command.Parameters.AddWithValue("@TotalAmount", model.TotalAmount);
                command.Parameters.AddWithValue("@Status", model.Status);
                command.Parameters.AddWithValue("@ContractID", model.ContractId);
                command.Parameters.AddWithValue("@StaffID", model.StaffId);

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
                command.CommandText = "SELECT * FROM tbInvoice ORDER BY InvoiceID ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var statusString = reader["Status"].ToString();
                        Enum.TryParse(statusString, true, out InvoiceStatus status);
                        
                        var invoice = new InvoiceModel
                        {
                            InvoiceId = (int)reader["InvoiceID"],
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            IssuedDate = (DateTime)reader["IssuedDate"],
                            RentFee = (decimal)reader["RentFee"],
                            ElectricityCost = (decimal)reader["ElectricityCost"],
                            WaterCost = (decimal)reader["WaterCost"],
                            TotalAmount = (decimal)reader["TotalAmount"],
                            Status = status,
                            ContractId = (int)reader["ContractId"],
                            StaffId = (int)reader["StaffId"]
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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("spGetInvoicesByValue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@InvoiceNo", SqlDbType.VarChar).Value = value;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var statusString = reader["Status"].ToString();
                        Enum.TryParse(statusString, true, out InvoiceStatus status);
                        
                        var invoice = new InvoiceModel
                        {
                            InvoiceId = (int)reader["InvoiceID"],
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            IssuedDate = (DateTime)reader["IssuedDate"],
                            RentFee = (decimal)reader["RentFee"],
                            ElectricityCost = (decimal)reader["ElectricityCost"],
                            WaterCost = (decimal)reader["WaterCost"],
                            TotalAmount = (decimal)reader["TotalAmount"],
                            Status = status,
                            ContractId = (int)reader["ContractId"],
                            StaffId = (int)reader["StaffId"]
                        };
                        list.Add(invoice);
                    }
                }
            }

            return list;
        }
        
        public static IEnumerable<Contract> GetAllContracts()
        {
            var contracts = new List<Contract>();
            using (var sqlConnection = new SqlConnection(DatabaseUtil.GetConnectionString()))
            using (var sqlCommand = new SqlCommand("SELECT c.ContractID, c.Code, c.Status, s.MonthlyFee AS RentFee " +
                                                   "FROM tbContract c " +
                                                   "INNER JOIN tbStall s ON c.StallID = s.StallID", sqlConnection))
            {
                sqlConnection.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var statusString = reader["Status"].ToString();
                        Enum.TryParse(statusString, true, out ContractStatus status);
                        
                        contracts.Add(new Contract
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ContractID")),
                            Code = reader.GetString(reader.GetOrdinal("Code")),
                            RentFee = reader.GetDecimal(reader.GetOrdinal("RentFee")),
                            Status = status
                        });
                    }
                }
            }
            return contracts;
        }
    }
}

