using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repository;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views.Supermarket_Contract_Forms
{
    public partial class FrmContract : Form, IContractView
    {
        private DateTime startDate;
        private DateTime endDate;

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
        public DateTime StartDate {
            get
            {
                if (DateTime.TryParseExact(startDateContract.Text, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    return parsedDate;
                }
                else
                {
                    throw new FormatException("Invalid start date format. Expected format is M/D/YYYY.");
                }
            }
            set
            {
                // Update the internal field and UI control
                startDate = value;
                startDateContract.Text = value.ToString("M/d/yyyy", CultureInfo.InvariantCulture);
            }
        }
        public DateTime EndDate {
            get
            {
                if (DateTime.TryParseExact(endDateConstract.Text, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    return parsedDate;
                }
                else
                {
                    throw new FormatException("Invalid end date format. Expected format is M/D/YYYY.");
                }
            }
            set
            {
                // Update the internal field and UI control
                endDate = value;
                endDateConstract.Text = value.ToString("M/d/yyyy", CultureInfo.InvariantCulture);
            }
        }
        public int StallId {
            get => int.Parse(contractStallIDComboBox.Text); 
            set => contractStallIDComboBox.Text = value.ToString(); 
        }
        public int StaffId {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
        public int VendorId {
            get => int.Parse(contractVendorIDComboBox.Text);
            set => contractVendorIDComboBox.Text=value.ToString();
        }


        public event EventHandler SaveContract;
        public event EventHandler SearchContract;
        public event EventHandler UpdateContract;
        public event EventHandler AddNewContract;
        public event EventHandler DownloadContract;

        public void SetContractBindingSource(BindingSource bindingSource)
        {
            contractDataGridView.DataSource = bindingSource;

        }
        public void SetStallIdOnComboBox(IEnumerable<int> stallIDs)
        {
            foreach(int id in stallIDs)
            {
                MessageBox.Show(id.ToString());
            }
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
            new ContractPresenter(this, new ContractRepository());


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

        private void contractUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.doc;*.docx|All Files|*.*"; // Filter to show only PDF and Word files
            openFileDialog.Title = "Select a contract file";
            //
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                // Check if the selected file has a valid extension
                string extension = Path.GetExtension(selectedFilePath);
                if (extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".doc", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".docx", StringComparison.OrdinalIgnoreCase))
                {
                    // Valid file selected, do something with it
                    // For example, display the seleted file name in a TextBox
                    contractUploadButton.Text = Path.GetFileName(selectedFilePath);
                }
                else
                {
                    MessageBox.Show("Please select a PDF or Word file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
