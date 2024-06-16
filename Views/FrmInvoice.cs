using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stall_Rental_Management_System.Views.InvoiceForm
{
    public partial class FrmInvoice : Form
    {
        SqlConnection con = new SqlConnection("Server=35.240.136.224,1433;Database=dbSRMS;User Id=sa;Password=ISADGroup3@RUPP;");

        public FrmInvoice()
        {
            InitializeComponent();
            btnUpdate.Click += new EventHandler(btnupdate_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
          //  textBox12.TextChanged += new EventHandler(textBox12_TextChanged);
        }

        private void FrmInvoice1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Connection to the database was successful!");
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database:\n" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT * FROM tbInvoice";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InsertInvoice();
            LoadData(); // Refresh the DataGridView after inserting a new record
        }

        private bool CheckContractIDExists(string contractID)
        {
            string query = "SELECT COUNT(*) FROM tbContract WHERE ContractID = @ContractID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ContractID", contractID);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void InsertInvoice()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (!CheckContractIDExists(ComboBoxContractID.Text))
                {
                    MessageBox.Show("The specified ContractID does not exist in the tbContract table.");
                    return;
                }

                string query = "INSERT INTO tbInvoice (FileURL, InvoiceNO, IssuedDate, RentFee, ElectricityCost, WaterCost, TotalAmount, Status, ContractID, StaffID) " +
                               "VALUES (@FileURL, @InvoiceNO, @IssuedDate, @RentFee, @ElectricityCost, @WaterCost, @TotalAmount, @Status, @ContractID, @StaffID)";
                SqlCommand cmd = new SqlCommand(query, con);

                // Assuming all your text boxes have valid input
                cmd.Parameters.AddWithValue("@FileURL", txtFileURL.Text);
                cmd.Parameters.AddWithValue("@InvoiceNO", txtInvoiceNO.Text);
                cmd.Parameters.AddWithValue("@IssuedDate", DateTime.Parse(txtIssuedDate.Text)); // Ensure this is a valid date
                cmd.Parameters.AddWithValue("@RentFee", decimal.Parse(txtRentFee.Text)); // Ensure this is a valid decimal
                cmd.Parameters.AddWithValue("@ElectricityCost", decimal.Parse(txtElectricityCost.Text)); // Ensure this is a valid decimal
                cmd.Parameters.AddWithValue("@WaterCost", decimal.Parse(txtWaterCost.Text)); // Ensure this is a valid decimal
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtTotalAmount.Text)); // Ensure this is a valid decimal
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@ContractID", ComboBoxContractID.Text);
                cmd.Parameters.AddWithValue("@StaffID", ComboBoxStaffID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Handle label11 click event
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Handle label12 click event
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle textBox1 text changed event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle dataGridView1 cell content click event
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtInvoiceID.Text = row.Cells["InvoiceID"].Value.ToString();
                txtFileURL.Text = row.Cells["FileURL"].Value.ToString();
                txtInvoiceNO.Text = row.Cells["InvoiceNO"].Value.ToString();
                txtIssuedDate.Text = row.Cells["IssuedDate"].Value.ToString();
                txtRentFee.Text = row.Cells["RentFee"].Value.ToString();
                txtElectricityCost.Text = row.Cells["ElectricityCost"].Value.ToString();
                txtWaterCost.Text = row.Cells["WaterCost"].Value.ToString();
                txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
                ComboBoxContractID.Text = row.Cells["ContractID"].Value.ToString();
                ComboBoxStaffID.Text = row.Cells["StaffID"].Value.ToString();
            }
        }

        private void ComboBoxContractID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "UPDATE tbInvoice SET FileURL=@FileURL, InvoiceNO=@InvoiceNO, IssuedDate=@IssuedDate, " +
                               "RentFee=@RentFee, ElectricityCost=@ElectricityCost, WaterCost=@WaterCost, " +
                               "TotalAmount=@TotalAmount, Status=@Status, ContractID=@ContractID, StaffID=@StaffID " +
                               "WHERE InvoiceID=@InvoiceID";

                SqlCommand cmd = new SqlCommand(query, con);

                // Assuming all your text boxes have valid input
                cmd.Parameters.AddWithValue("@InvoiceID", txtInvoiceID.Text);
                cmd.Parameters.AddWithValue("@FileURL", txtFileURL.Text);
                cmd.Parameters.AddWithValue("@InvoiceNO", txtInvoiceNO.Text);
                cmd.Parameters.AddWithValue("@IssuedDate", DateTime.Parse(txtIssuedDate.Text));
                cmd.Parameters.AddWithValue("@RentFee", decimal.Parse(txtRentFee.Text));
                cmd.Parameters.AddWithValue("@ElectricityCost", decimal.Parse(txtElectricityCost.Text));
                cmd.Parameters.AddWithValue("@WaterCost", decimal.Parse(txtWaterCost.Text));
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtTotalAmount.Text));
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@ContractID", ComboBoxContractID.Text);
                cmd.Parameters.AddWithValue("@StaffID", ComboBoxStaffID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                LoadData(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "DELETE FROM tbInvoice WHERE InvoiceID=@InvoiceID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@InvoiceID", txtInvoiceID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");

                LoadData(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT * FROM tbInvoice WHERE InvoiceNO LIKE @SearchText + '%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@SearchText", txtSearch.Text);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
