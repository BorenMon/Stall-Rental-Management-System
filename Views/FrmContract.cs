using Minio;
using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;

namespace Stall_Rental_Management_System.Views.Supermarket_Contract_Forms
{
    public partial class FrmContract : Form, IContractView
    {
        private DateTime startDate;
        private DateTime endDate;
        private string seletedFilePath;
        private string fileName;
        private string minioFileUrl;
        private int stallID;
        private int staffID;
        private int vendorID;
        private string minIOUrl;
        private string contractID;
        // Specify the format of the input string
        private string dateformat = "M/d/yyyy";
        private ToolTip toolTip = new ToolTip();


        public string ContractId
        {
            get { return contractID; }
            set { contractID = value; }

        }
        public string FileUrl
        {
            get => minioFileUrl;
            set { minioFileUrl = value; }
        }
        public string Code
        {
            get => contractCodeText.Text;
            set => contractCodeText.Text = value;
        }
        public string Status
        {
            get => contractStatusComboBox.SelectedItem.ToString(); 
            set => contractStatusComboBox.SelectedItem = value;
        }
        public DateTime StartDate
        {
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
        public DateTime EndDate
        {
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
        public int StallId
        {
            get {
                return int.Parse(contractStallIDComboBox.SelectedItem.ToString());
            }
            set => contractStallIDComboBox.SelectedItem = value;
        }
        public int StaffId
        {
            get => int.Parse(staffIdComboBox.SelectedItem.ToString());
            set => staffIdComboBox.SelectedItem = value;
        }
        public int VendorId
        {
            get => int.Parse(contractVendorIDComboBox.SelectedItem.ToString());
            set => contractVendorIDComboBox.SelectedItem = value;
        }
        public string SeletedFilePath {
            get => seletedFilePath;
            set => seletedFilePath = value;
        }
        public string FileName {
            get
            {
                return fileName;
            }
            set { fileName = value; }
        }

        public event EventHandler SaveContract;
        public event EventHandler SearchContract;
        public event EventHandler UpdateContract;
        public event EventHandler AddNewContract;
        public event EventHandler DownloadContract;

        public void SetContractBindingSource(BindingSource bindingSource)
        {
            if (bindingSource.Count == 0)
            {
                
            }
            contractDataGridView.DataSource = bindingSource;
            
            for(int i = 0;i < 7;i++ )
            {
                contractDataGridView.Columns[i].Width = 150;

            }

        }
        public void SetStallIdOnComboBox(IEnumerable<int> stallIDs)
        {
            foreach (int id in stallIDs)
            {
                contractStallIDComboBox.Items.Add(id);
            }

        }
        public void SetVendorIdOnComboBox(IEnumerable<int> vendorID)
        {
            foreach (int id in vendorID)
            {
                contractVendorIDComboBox.Items.Add(id);
            }
        }
        public FrmContract()
        {
            InitializeComponent();
            //adding title for each button do
            toolTip.SetToolTip(downloadButton, "Click to download contract as file");
            toolTip.SetToolTip(saveButton, "To save contract information");
            toolTip.SetToolTip(updateButton, "To update contract information");
            toolTip.SetToolTip(newButton, "To create new contract information");
            toolTip.SetToolTip(logoutButton, "Logout");

            //disable button
            saveButton.Enabled = false;
            updateButton.Enabled = false;
            downloadButton.Enabled = false;
            // set value to combobox
            contractStatusComboBox.Items.Add("available");
            contractStatusComboBox.Items.Add("unavailable");
            contractStatusComboBox.SelectedItem = "available";
            // staff ID
            staffIdComboBox.Items.Add("1");
            staffIdComboBox.SelectedItem = "1";

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
                else if (k.KeyCode == Keys.Back)
                {
                    // reload database
                    ReloadDatabase();
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
            //SeletedFilePath = seletedFilePath;
            //FileUrl = fileName;
            //stallID = int.Parse(contractStallIDComboBox.SelectedItem.ToString());
            //staffID = int.Parse(staffIdComboBox.SelectedItem.ToString());
            //vendorID = int.Parse(contractVendorIDComboBox.SelectedItem.ToString());
            SaveContract?.Invoke(this, EventArgs.Empty);
            clearAllTextValue();
            // reload database
            ReloadDatabase();
        }

        private void contractDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enableAllWindowsFormComponents();
            contractCodeText.Enabled = false;
            saveButton.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = contractDataGridView.Rows[e.RowIndex];
                contractID = row.Cells[0].Value.ToString();
                FileUrl = row.Cells[1].Value.ToString();
                contractUploadButton.Text = MinIOObjectNameUtil.GetOnlyObjectName(FileUrl);
                // get value back from seleting on row
                contractCodeText.Text = row.Cells[2].Value.ToString();
                contractStatusComboBox.Text = row.Cells[3].Value.ToString();
                DateTime.TryParse(row.Cells[4].Value.ToString(), out startDate);
                startDateContract.Value = startDate;
                DateTime.TryParse(row.Cells[5].Value.ToString(), out endDate);
                endDateConstract.Value = endDate;
                //
                contractStallIDComboBox.Text = (row.Cells[6].Value.ToString());
                //contractStallIDComboBox.SelectedItem = StallId;
                contractVendorIDComboBox.Text = (row.Cells[7].Value.ToString());
                //contractVendorIDComboBox.SelectedItem = VendorId;
                staffIdComboBox.Text = (row.Cells[8].Value.ToString());
                //staffIdComboBox.SelectedItem = StaffId;
                //enable button
                updateButton.Enabled = true;
                downloadButton.Enabled = true;
            }
        }


        private void contractUploadButton_Click(object sender, EventArgs e)
        {
            contractUploadButton.Text = uploadFileAndPreviewFileName();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //enable button
            saveButton.Enabled = true;
            updateButton.Enabled = false;
            downloadButton.Enabled = false;
            enableAllWindowsFormComponents();
            staffIdComboBox.Enabled = false;
            contractCodeText.Focus();
            clearAllTextValue();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            // Get the user's Downloads folder path
            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string objectName = MinIOObjectNameUtil.GetOnlyObjectName(FileUrl);
            string bucketName = "srms";
            try
            {
                // Retrieve object information to get the MIME type
                var statObject = await MinIOUtil.GetMinioClient()
                    .StatObjectAsync(
                    new StatObjectArgs()
                    .WithBucket(bucketName)
                    .WithObject(objectName)
                    );
                string contentType = statObject.ContentType;

                // Create a SaveFileDialog instance and set the default file name and filter
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = $"{contentType} files (*.{contentType.Split('/')[1]})|*.{contentType.Split('/')[1]}";
                saveFileDialog.Title = "Save File";
                saveFileDialog.FileName = objectName;
                saveFileDialog.InitialDirectory = downloadsFolderPath;

                // Show the SaveFileDialog and get the result
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected file path
                    string downloadFilePath = saveFileDialog.FileName;
                    try
                    {
                        // Download the file from MinIO
                        await MinIOUtil.GetMinioClient()
                            .GetObjectAsync(
                            new GetObjectArgs()
                            .WithBucket(bucketName)
                            .WithObject(objectName)
                            .WithFile(downloadFilePath)
                            );
                        // Open the downloaded file
                        //Process.Start(downloadFilePath);
                        MessageBox.Show("File downloaded successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error downloading file: {ex.Message}",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
    "Error", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateContract?.Invoke(this, EventArgs.Empty);
            //staffIdComboBox.Enabled = false;
            disableAllWindowsFormComponent();
            MessageBox.Show("Updated contract information successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAllTextValue();
            // reload database
            ReloadDatabase();
        }
        private void enableAllWindowsFormComponents()
        {
            contractCodeText.Enabled = true;
            contractUploadButton.Enabled = true;
            contractStatusComboBox.Enabled = true;
            startDateContract.Enabled = true;
            endDateConstract.Enabled = true;
            contractStallIDComboBox.Enabled = true;
            contractVendorIDComboBox.Enabled= true;
            staffIdComboBox.Enabled = true;

        }
        private void disableAllWindowsFormComponent()
        {
            contractCodeText.Enabled = false;
            contractUploadButton.Enabled = false;
            contractStatusComboBox.Enabled = false;
            startDateContract.Enabled = false;
            endDateConstract.Enabled = false;
            contractStallIDComboBox.Enabled = false;
            contractVendorIDComboBox.Enabled = false;
            staffIdComboBox.Enabled = false;
        }
        private void clearAllTextValue()
        {
            contractCodeText.Text = "";
            contractStallIDComboBox.Text = "";
            contractStatusComboBox.Text = "";
            contractVendorIDComboBox.Text = "";
            startDateContract.Text = "";
            endDateConstract.Text = "";
            contractUploadButton.Text = "Upload Contract File";
        }
        private string uploadFileAndPreviewFileName()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.doc;*.docx|All Files|*.*"; // Filter to show only PDF and Word files
            openFileDialog.Title = "Select a contract file";

            //
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                seletedFilePath = openFileDialog.FileName;

                // Check if the selected file has a valid extension
                string extension = Path.GetExtension(seletedFilePath);
                if (extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".doc", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".docx", StringComparison.OrdinalIgnoreCase))
                {
                    // Valid file selected, do something with it
                    // For example, display the seleted file name in a TextBox
                    fileName =  Path.GetFileName(seletedFilePath);
                }
                //
                else
                {
                    MessageBox.Show("Please select a PDF or Word file.", 
                        "Invalid File Type", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            return fileName;
        }
        private void ReloadDatabase() {
            contractDataGridView.DataSource
            = new ContractPresenter(new ContractRepository()).LoadAllContractData();
        }
    }
}
