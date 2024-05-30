using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views.Supermarket_Contract_Forms
{
    public partial class FrmContract : Form
    {
        public FrmContract()
        {
            InitializeComponent();
            //making form to be center write below statement in form constrcutor
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // Set the form's properties to create a fixed size form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Set to false if you don't want the minimize button
                                     //this.Size = new System.Drawing.Size(1000, 800); // Set your desired form size
                                     //this.MaximumSize = new System.Drawing.Size(800, 600);
                                     //this.MinimumSize = new System.Drawing.Size(800, 600);
            //todo table

        }

        private void FrmContract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSRMSDataSet1.SokphengTestContract' table. You can move, or remove it, as needed.
            this.sokphengTestContractTableAdapter.Fill(this.dbSRMSDataSet1.SokphengTestContract);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string data = contractCodeText.Text + "/" + startDateContract.Text;
      
            if (contractCodeText.Text.Equals(""))
            {
                MessageBox.Show("Code is not empty","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            contractCodeText.Text = "";
            contractStallIDComboBox.Text = "";
            contractStatusComboBox.Text = "";
            contractVendorIDComboBox.Text = "";
            startDateContract.Text = "";
            endDateConstract.Text = "";
        }
    }
}
