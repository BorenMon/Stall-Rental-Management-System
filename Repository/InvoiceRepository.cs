using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly string connectionString;

        public InvoiceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<InvoiceModel> GetAll()
        {
            var invoices = new List<InvoiceModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM tbInvoice";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var invoice = new InvoiceModel
                    {
                        InvoiceID = (int)reader["InvoiceID"],
                        FileURL = reader["FileURL"].ToString(),
                        InvoiceNO = reader["InvoiceNO"].ToString(),
                        IssuedDate = (DateTime)reader["IssuedDate"],
                        RentFee = (decimal)reader["RentFee"],
                        ElectricityCost = (decimal)reader["ElectricityCost"],
                        WaterCost = (decimal)reader["WaterCost"],
                        TotalAmount = (decimal)reader["TotalAmount"],
                        Status = reader["Status"].ToString(),
                        ContractID = reader["ContractID"].ToString(),
                        StaffID = reader["StaffID"].ToString()
                    };
                    invoices.Add(invoice);
                }
            }

            return invoices;
        }

        public void Add(InvoiceModel invoice)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbInvoice (FileURL, InvoiceNO, IssuedDate, RentFee, ElectricityCost, WaterCost, TotalAmount, Status, ContractID, StaffID) " +
                               "VALUES (@FileURL, @InvoiceNO, @IssuedDate, @RentFee, @ElectricityCost, @WaterCost, @TotalAmount, @Status, @ContractID, @StaffID)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FileURL", invoice.FileURL);
                cmd.Parameters.AddWithValue("@InvoiceNO", invoice.InvoiceNO);
                cmd.Parameters.AddWithValue("@IssuedDate", invoice.IssuedDate);
                cmd.Parameters.AddWithValue("@RentFee", invoice.RentFee);
                cmd.Parameters.AddWithValue("@ElectricityCost", invoice.ElectricityCost);
                cmd.Parameters.AddWithValue("@WaterCost", invoice.WaterCost);
                cmd.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                cmd.Parameters.AddWithValue("@Status", invoice.Status);
                cmd.Parameters.AddWithValue("@ContractID", invoice.ContractID);
                cmd.Parameters.AddWithValue("@StaffID", invoice.StaffID);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(InvoiceModel invoice)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbInvoice SET FileURL=@FileURL, InvoiceNO=@InvoiceNO, IssuedDate=@IssuedDate, " +
                               "RentFee=@RentFee, ElectricityCost=@ElectricityCost, WaterCost=@WaterCost, " +
                               "TotalAmount=@TotalAmount, Status=@Status, ContractID=@ContractID, StaffID=@StaffID " +
                               "WHERE InvoiceID=@InvoiceID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@InvoiceID", invoice.InvoiceID);
                cmd.Parameters.AddWithValue("@FileURL", invoice.FileURL);
                cmd.Parameters.AddWithValue("@InvoiceNO", invoice.InvoiceNO);
                cmd.Parameters.AddWithValue("@IssuedDate", invoice.IssuedDate);
                cmd.Parameters.AddWithValue("@RentFee", invoice.RentFee);
                cmd.Parameters.AddWithValue("@ElectricityCost", invoice.ElectricityCost);
                cmd.Parameters.AddWithValue("@WaterCost", invoice.WaterCost);
                cmd.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                cmd.Parameters.AddWithValue("@Status", invoice.Status);
                cmd.Parameters.AddWithValue("@ContractID", invoice.ContractID);
                cmd.Parameters.AddWithValue("@StaffID", invoice.StaffID);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int invoiceID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbInvoice WHERE InvoiceID=@InvoiceID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                cmd.ExecuteNonQuery();
            }
        }

        public bool ContractIDExists(string contractID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tbContract WHERE ContractID = @ContractID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ContractID", contractID);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}

