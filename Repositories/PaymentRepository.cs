using Microsoft.ReportingServices.Diagnostics.Internal;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stall_Rental_Management_System.Repositories
{
    internal class PaymentRepository
    {
        private SqlConnection sqlConnection;
        public PaymentRepository()
        {
            try
            {
                sqlConnection = DatabaseUtil.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add(PaymentModel model, PaymentReferenceModel referenceModel)
        {
            int pID = 0;
            openDatabaseConnection();
            string sql = @"INSERT INTO tbPayment
                   (PaymentMethod, PaymentDate, Status, Currency,
                    Amount, InvoiceID)
                   VALUES (@method, @date, @st,@cr,@am,@inID); SELECT SCOPE_IDENTITY();";
            //
            string sql1 = @"INSERT INTO tbPaymentReference
                   (ImageURL, FileName, PaymentID)
                   VALUES (@img, @file, @pID)";

            using (var sqlCommand = new SqlCommand(sql, sqlConnection)
            
                )
           
            {

                sqlCommand.Parameters.AddWithValue("@method", model.PaymentMethod);
                sqlCommand.Parameters.AddWithValue("@date",model.PaymentDate);
                sqlCommand.Parameters.AddWithValue("@st", model.Status);
                sqlCommand.Parameters.AddWithValue("@cr", model.Currency);
                sqlCommand.Parameters.AddWithValue("@am", model.Amount);
                sqlCommand.Parameters.AddWithValue("@inID",model.InvoiceID);
                try
                {
                    pID = int.Parse(sqlCommand.ExecuteScalar().ToString());
           

                    if (pID > 0)
                    {
                        MessageBox.Show("Payment has been created successfully",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot create new Payment",
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
            using (var sqlCommand1 = new SqlCommand(sql1, sqlConnection))
            {
                sqlCommand1.Parameters.AddWithValue("@img", referenceModel.ImageURL);
                sqlCommand1.Parameters.AddWithValue("@file", referenceModel.FileName);
                sqlCommand1.Parameters.AddWithValue("@pID", pID); ;
                try {
                    int rowAffected1 = sqlCommand1.ExecuteNonQuery();
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
        public void InsertToPaymentReferenceTable(PaymentReferenceModel referenceModel) { 

        }
        public IEnumerable<PaymentModel> getPaymentBYID(int pID)
        {
            var paymentList = new List<PaymentModel>();
            using (var sqlCommand = new SqlCommand())
            {
                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbPayment WHERE PaymentID=@id
                                           ";

                //
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = pID.ToString();
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var paymentModel = new PaymentModel();
                        paymentModel.PaymentID = (int)reader[0];
                        paymentModel.PaymentMethod = (string)reader[1];
                        paymentModel.PaymentDate = (DateTime)reader[2];
                        paymentModel.Status = (string)reader[3];
                        paymentModel.Currency = (string)reader[4];
                        paymentModel.Amount = (decimal)reader[5];
                        paymentModel.InvoiceID = (int)reader[6];
                        paymentList.Add(paymentModel);
                    }
                }
                sqlConnection.Close();
                return paymentList;
            }
        }
        public int DeletePaymentByID(int id)

        {
            openDatabaseConnection();
            string deleteQuery = "DELETE FROM tbPayment WHERE PaymentID = @RecordID";
            string deleteQuery1 = "DELETE FROM tbPaymentReference WHERE PaymentReferenceID = @pID";

            try
            {
                using (SqlCommand command = new SqlCommand(deleteQuery1, sqlConnection))
                {
                    command.Parameters.AddWithValue("@pID", id);
                    // Show confirmation dialog
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete payment with ID {id}?",
                        "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@RecordID", id);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            return 0;
        }
        public PaymentReferenceModel getPaymentModelReferencePaymentByID(int id)
        {
            var refer = new PaymentReferenceModel();
            using (var sqlCommand = new SqlCommand())
            {
                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbPaymentReference WHERE PaymentReferenceID=@id
                                           ";

                //
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id.ToString();
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        refer.PaymentID = (int)reader[3];
                        refer.ImageURL = (string)reader[1];
                        
                        refer.FileName = (string)reader[2];
                        refer.PaymentReferenceID = (int)reader[0];
                    }
                }
                sqlConnection.Close();
                return refer;
            }
        }
        public IEnumerable<int> getAllInvoiceIDs()
        {
            var ids = new List<int>();
            using (var sqlCommand = new SqlCommand())
            {
                openDatabaseConnection();
                // get all vendors
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT InvoiceID FROM tbInvoice";
               using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add((int)reader[0]);
                    }
                }

            }
            sqlConnection.Close();
            return ids;
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
        public IEnumerable<PaymentReferenceModel> GetAllPaymentReferencces()
        {
            var paymentList = new List<PaymentReferenceModel>();
            using (var sqlCommand = new SqlCommand())
            {
                openDatabaseConnection();
                // get all vendors
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbPaymentReference
                                           ORDER BY PaymentReferenceID DESC
                                           ";

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model= new PaymentReferenceModel();
                        model.PaymentReferenceID = (int)reader[0];
                        model.ImageURL = (string)reader[1];
                        model.FileName = (string)reader[2];
                        model.PaymentID = (int)reader[3];
                        paymentList.Add(model);
                    }
                }

            }
            sqlConnection.Close();
            return paymentList;
        }
        public IEnumerable<PaymentModel> GetAll()
        {
            var paymentList = new List<PaymentModel>();
            using (var sqlCommand = new SqlCommand())
            {
                openDatabaseConnection();
                // get all vendors
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbPayment
                                           ORDER BY PaymentID DESC
                                           ";

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var paymentModel = new PaymentModel();
                        paymentModel.PaymentID = (int)reader[0];
                        paymentModel.PaymentMethod = (string)reader[1];
                        paymentModel.PaymentDate = (DateTime)reader[2];
                        paymentModel.Status = (string)reader[3];
                        paymentModel.Currency = (string)reader[4];
                        paymentModel.Amount = (decimal)reader[5];
                        paymentModel.InvoiceID = (int)reader[6];    
                        paymentList.Add(paymentModel);
                    }
                }

            }
            sqlConnection.Close();
            return paymentList ;
        }
        public void updatePayment(PaymentModel paymentModel)
        {
            sqlConnection.Open();
            using (SqlCommand command = new SqlCommand("spUpdatePayment", sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters with matching data types
                command.Parameters.AddWithValue("@PaymentID", paymentModel.PaymentID);
                command.Parameters.AddWithValue("@PaymentMethod", paymentModel.PaymentMethod);
                command.Parameters.AddWithValue("@PaymentDate", paymentModel.PaymentDate);
                command.Parameters.AddWithValue("@Status", paymentModel.Status);
                command.Parameters.AddWithValue("@Currency", paymentModel.Currency);
                command.Parameters.AddWithValue("@Amount", paymentModel.Amount);
                command.Parameters.AddWithValue("@InvoiceID", paymentModel.InvoiceID);
                command.ExecuteNonQuery();
                MessageBox.Show("Payment has been updated successfully",
      "Success", MessageBoxButtons.OK,
      MessageBoxIcon.Information);
            }
            sqlConnection.Close();
        }
    }
}
