using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repository;
using Stall_Rental_Management_System.Views.View_Interfaces;
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
    public partial class FrmContract : Form, IContractView
    {
        private string code;

        public string ContractId {
             get { return contractSearchTextBox.Text;}
             set { contractSearchTextBox.Text = value; }

        }
        public string FileUrl { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public string Code {
            get => contractCodeText.Text;
            set => contractCodeText.Text = value;
        }
        public string Status { 
            get => contractStatusComboBox.Text;
            set => contractStatusComboBox.Text = value; }
        public DateTime StartDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EndDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StallId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StaffId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VendorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public event EventHandler SaveContract;
        public event EventHandler SearchContract;
        public event EventHandler UpdateContract;
        public event EventHandler AddNewContract;
        public event EventHandler DownloadContract;

        public void SetContractBindingSource(BindingSource bindingSource)
        {
            contractDataGridView.DataSource = bindingSource;

        }
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
            
            //new ContractPresenter(this, new ContractRepository());;
            // trigger search event
            searchButton.Click += delegate { SearchContract?.Invoke(this, EventArgs.Empty); };
            contractSearchTextBox.KeyDown += (e1, k) =>
            {
                if (k.KeyCode == Keys.Enter)
                {
                    k.SuppressKeyPress = true;
                    SearchContract?.Invoke(this, EventArgs.Empty);
                }
                else if(k.KeyCode == Keys.Back) {
                    new ContractPresenter(this, new ContractRepository());
                }

            };
        }


        private void FrmContract_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dbSRMSDataSet2.tbContract' table. You can move, or remove it, as needed.
            //this.tbContractTableAdapter.Fill(this.dbSRMSDataSet2.tbContract);
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(contractCodeText.Text + "|" + contractStallIDComboBox.Text 
            //     + "|" + startDateContract.Text + "|" + contractStatusComboBox.Text);
            SaveContract?.Invoke(this,EventArgs.Empty);
            clearAllTextValue();

        }

        private void contractDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = contractDataGridView.Rows[e.RowIndex];
                string rowData = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData += cell.Value.ToString() + " ";
                }
                MessageBox.Show("Row data: " + rowData.Trim());
            }
        }

        private void newButton_Click_1(object sender, EventArgs e)
        {
            clearAllTextValue();
        }
        private void clearAllTextValue()
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
