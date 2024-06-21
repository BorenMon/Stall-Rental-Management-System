using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Stall_Rental_Management_System.Views.Supermarket_Staff_Forms
{
    //SqlConnection connectionString = new SqlConnection("Server=34.87.58.157,1433;Database=dbSRMS;User Id=sa;Password=ISADGroup3@RUPP;");
    public partial class FrmSupportTicket : Form
    {
        private int currentSupportTicketID; 
        private string connectionString = "Server=34.87.58.157,1433;Database=dbSRMS;User Id=sa;Password=ISADGroup3@RUPP;";
        public FrmSupportTicket()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FrmSupportTicket_Load);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
        }

        private void FrmSupportTicket_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }
        private void LoadTickets()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT SupportTicketID AS ID, Subject, VendorID, StaffID FROM tbSupportTicket";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gBox.DataSource = dt;
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tbSupportTicket (Subject, Message, Response, Status, VendorID, StaffID) VALUES (@Subject, @Message, @Response, @Status, @VendorID, @StaffID)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Subject", txtSub.Text);
                    cmd.Parameters.AddWithValue("@Message", txtMess.Text);
                    cmd.Parameters.AddWithValue("@Response", txtRes.Text);
                    cmd.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VendorID", int.Parse(txtVen.Text));
                    cmd.Parameters.AddWithValue("@StaffID", int.Parse(txtSta.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket saved successfully.");
                    con.Close();
                    LoadTickets();  // Refresh the data grid view
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tbSupportTicket SET Subject=@Subject, Message=@Message, Response=@Response, Status=@Status, VendorID=@VendorID, StaffID=@StaffID WHERE SupportTicketID=@SupportTicketID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Subject", txtSub.Text);
                    cmd.Parameters.AddWithValue("@Message", txtMess.Text);
                    cmd.Parameters.AddWithValue("@Response", txtRes.Text);
                    cmd.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VendorID", int.Parse(txtVen.Text));
                    cmd.Parameters.AddWithValue("@StaffID", int.Parse(txtSta.Text));

                    // Assuming you have a way to get the SupportTicketID, e.g., from a hidden field or selected item
                    cmd.Parameters.AddWithValue("@SupportTicketID", currentSupportTicketID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket updated successfully.");
                    con.Close();
                    LoadTickets();  // Refresh the data grid view
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT SupportTicketID AS ID, Subject, VendorID, StaffID FROM tbSupportTicket WHERE Status=@Status";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gBox.DataSource = dt;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSub.Text = "";
            txtMess.Text = "";
            txtRes.Text = "";
            txtVen.Text = "";
            txtSta.Text = "";
            cbStatus.SelectedIndex = -1; // Reset combobox selection
        }
    }
}
