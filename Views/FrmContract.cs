using Minio.DataModel.Args;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.DesignHelpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmContract : Form, IContractView
    {
        private readonly ToolTip _toolTip = new ToolTip();
        private readonly AuthenticationService _authService;

        public FrmContract(AuthenticationService authService)
        {
            InitializeComponent();
            _authService = authService;
            //adding title for each button do
            _toolTip.SetToolTip(downloadButton, "Click to download contract as file");
            _toolTip.SetToolTip(saveButton, "To save contract information");
            _toolTip.SetToolTip(updateButton, "To update contract information");
            _toolTip.SetToolTip(newButton, "To create new contract information");
            _toolTip.SetToolTip(logoutButton, "Logout");

            //disable button
            saveButton.Enabled = false;
            updateButton.Enabled = false;
            downloadButton.Enabled = false;

            //making form to be center write below statement in form constructor
            StartPosition = FormStartPosition.CenterScreen;
            //
            // Set the form's properties to create a fixed size form
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = true;
            var contractPresenter = new ContractPresenter(this, new ContractRepository());


            // trigger search event
            searchButton.Click += delegate { SearchContract?.Invoke(this, EventArgs.Empty); };

            contractSearchTextBox.KeyDown += (e1, k) =>
            {
                
                if (k.KeyCode == Keys.Enter)
                {
                    //k.SuppressKeyPress = true;
                    ContractId = contractSearchTextBox.Text;
                    SearchContract?.Invoke(this, EventArgs.Empty);
                    //new ContractPresenter(this, new ContractRepository());
                    contractSearchTextBox.Text = "";
                    //
                    CheckIfDataNotFound();
                }
                else if (k.KeyCode == Keys.Back)
                {
                    contractSearchTextBox.Text = "";
                }
            };
            
            contractStatusComboBox.DataSource = EnumHelper.GetEnumDisplayNames<ContractStatus>();
            contractStatusComboBox.DisplayMember = "Value";
            contractStatusComboBox.ValueMember = "Key";
            
            textBoxStaffId.ReadOnly = true;
        }

        public string ContractId { get; set; }

        public string FileUrl { get; set; }

        public string Code
        {
            get => contractCodeText.Text;
            set => contractCodeText.Text = value;
        }
        public ContractStatus Status
        {
            get => (ContractStatus)contractStatusComboBox.SelectedValue;
            set => contractStatusComboBox.SelectedValue = value;
        }
        public DateTime StartDate
        {
            get => startDateContract.Value;
            set => startDateContract.Value = value;
        }
        public DateTime EndDate
        {
            get => endDateConstract.Value;
            set => endDateConstract.Value = value;
        }
        public int StallId
        {
            get =>
                string.IsNullOrWhiteSpace(contractStallIDComboBox.Text) ? 0 : // or any default value you consider appropriate
                    int.Parse(contractStallIDComboBox.Text);
            set => contractStallIDComboBox.Text = value.ToString();
        }

        public int StaffId
        {
            get => int.Parse(textBoxStaffId.Text);
            set => textBoxStaffId.Text = value.ToString();
        }
        public int VendorId
        {
            get =>
                string.IsNullOrWhiteSpace(contractVendorIDComboBox.Text) ? 0 : // or any default value you consider appropriate
                    int.Parse(contractVendorIDComboBox.Text);
            set => contractVendorIDComboBox.Text = value.ToString();
        }
        public string SelectedFilePath { get; set; }

        public string FileName { get; set; }

        public event EventHandler SaveContract;
        public event EventHandler SearchContract;
        public event EventHandler UpdateContract;
        public event EventHandler AddNewContract;
        public event EventHandler ViewEvent;

        public void SetContractBindingSource(BindingSource contractList)
        {
            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("Code", "Code"),
                ("Status", "Status"),
                ("StaffID", "Staff ID"),
                ("StallID", "Stall ID"),
                ("VendorID", "Vendor ID"),
            };

            DataGridViewHelper.SetDataGridViewColumns(contractDataGridView, contractList, columns);
        }
        public void SetStallIdOnComboBox(IEnumerable<int> stallIDs)
        {
            contractStallIDComboBox.Items.Clear();
            foreach (var id in stallIDs)
            {
                contractStallIDComboBox.Items.Add(id);
            }
        }
        public void SetVendorIdOnComboBox(IEnumerable<int> vendorIDs)
        {
            contractVendorIDComboBox.Items.Clear();
            foreach (var id in vendorIDs)
            {
                contractVendorIDComboBox.Items.Add(id);
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (
                contractCodeText.Text == "" ||
                ReferenceEquals(contractStatusComboBox.SelectedItem, "") ||
                ReferenceEquals(contractStallIDComboBox.SelectedItem, "") ||
                ReferenceEquals(contractVendorIDComboBox.SelectedItem, "") ||
                contractUploadButton.Text == @"Upload Contract File (PDF, Doc)"
                )
            {
                MessageBox.Show(@"You missed any input field.",@"Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SaveContract?.Invoke(this, EventArgs.Empty);
            if (!IsSuccessful) return;
            ClearAllTextValue();
        }

        private void contractDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableAllWindowsFormComponents();
            contractCodeText.ReadOnly = true;
            saveButton.Enabled = false;
            
            ViewEvent?.Invoke(this, EventArgs.Empty);
            contractUploadButton.Text = MinIoObjectNameUtil.GetOnlyObjectName(FileUrl);
            contractStatusComboBox.Enabled = Status != ContractStatus.CLOSED;

            contractStallIDComboBox.Enabled = false;
            contractVendorIDComboBox.Enabled = false;
            updateButton.Enabled = CurrentUserUtil.User.UserId == StaffId && Status == ContractStatus.ACTIVE;
            downloadButton.Enabled = true;
        }


        private void contractUploadButton_Click(object sender, EventArgs e)
        {
            contractUploadButton.Text = UploadFileAndPreviewFileName();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //enable button
            saveButton.Enabled = true;
            updateButton.Enabled = false;
            downloadButton.Enabled = false;
            contractStatusComboBox.Enabled = false;
            contractStallIDComboBox.Enabled = true;
            contractVendorIDComboBox.Enabled = true;
            EnableAllWindowsFormComponents();
            ClearAllTextValue();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            // Get the user's Downloads folder path
            var downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            var objectName = MinIoObjectNameUtil.GetOnlyObjectName(FileUrl);
            const string bucketName = "srms";
            try
            {
                // Retrieve object information to get the MIME type
                var statObject = await MinIoUtil.GetMinioClient()
                    .StatObjectAsync(
                    new StatObjectArgs()
                    .WithBucket(bucketName)
                    .WithObject(objectName)
                    );
                var contentType = statObject.ContentType;

                // Create a SaveFileDialog instance and set the default file name and filter
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = $@"{contentType} files (*.{contentType.Split('/')[1]})|*.{contentType.Split('/')[1]}";
                saveFileDialog.Title = @"Save File";
                saveFileDialog.FileName = objectName;
                saveFileDialog.InitialDirectory = downloadsFolderPath;

                // Show the SaveFileDialog and get the result
                var result = saveFileDialog.ShowDialog();

                if (result != DialogResult.OK) return;
                // Get the selected file path
                var downloadFilePath = saveFileDialog.FileName;
                try
                {
                    // Download the file from MinIO
                    await MinIoUtil.GetMinioClient()
                        .GetObjectAsync(
                            new GetObjectArgs()
                                .WithBucket(bucketName)
                                .WithObject(objectName)
                                .WithFile(downloadFilePath)
                        );
                    // Open the downloaded file
                    //Process.Start(downloadFilePath);
                    MessageBox.Show(@"File downloaded successfully!", @"Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show($@"Error downloading file: {ex.Message}",
                        @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
    @"Error", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateContract?.Invoke(this, EventArgs.Empty);

            if (!IsSuccessful) return;
            
            MessageBox.Show(@"Updated contract information successfully!", @"Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAllTextValue();
            DisableAllWindowsFormComponent();
        }

        public bool IsSuccessful { get; set; }

        private void EnableAllWindowsFormComponents()
        {
            contractUploadButton.Enabled = true;
            startDateContract.Enabled = true;
            endDateConstract.Enabled = true;
            contractStallIDComboBox.Enabled = true;
            contractVendorIDComboBox.Enabled= true;

        }
        private void DisableAllWindowsFormComponent()
        {
            contractCodeText.Enabled = false;
            contractUploadButton.Enabled = false;
            updateButton.Enabled = false;
            downloadButton.Enabled = false;
            contractStatusComboBox.Enabled = false;
            startDateContract.Enabled = false;
            endDateConstract.Enabled = false;
            contractStallIDComboBox.Enabled = false;
            contractVendorIDComboBox.Enabled = false;
        }
        private void ClearAllTextValue()
        {
            FileUrl = string.Empty;
            contractCodeText.Text = CodeGeneratorUtil.GenerateRandomCode(8);
            contractStallIDComboBox.Text = "";
            contractVendorIDComboBox.Text = "";
            startDateContract.Text = "";
            endDateConstract.Text = "";
            contractUploadButton.Text = @"Upload Contract File";
            textBoxStaffId.Text = CurrentUserUtil.User.UserId.ToString();
        }
        private string UploadFileAndPreviewFileName()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"PDF Files|*.pdf|Word Files|*.doc;*.docx|All Files|*.*"; // Filter to show only PDF and Word files
            openFileDialog.Title = @"Select a contract file";

            //
            if (openFileDialog.ShowDialog() != DialogResult.OK) return FileName;
            SelectedFilePath = openFileDialog.FileName;

            // Check if the selected file has a valid extension
            var extension = Path.GetExtension(SelectedFilePath);
            if (extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase) ||
                extension.Equals(".doc", StringComparison.OrdinalIgnoreCase) ||
                extension.Equals(".docx", StringComparison.OrdinalIgnoreCase))
            {
                // Valid file selected, do something with it
                // For example, display the selected file name in a TextBox
                FileName =  Path.GetFileName(SelectedFilePath);
            }
            //
            else
            {
                MessageBox.Show(@"Please select a PDF or Word file.", 
                    @"Invalid File Type", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            return FileName;
        }
        
        private void CheckIfDataNotFound()
        {
            var b = (BindingSource)contractDataGridView.DataSource;
            if (b.Count != 0) return;
            MessageBox.Show(@"No Data was found!", @"Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUserUtil.Logout(this, _authService);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            GeneralNavigateHelper.NavigateToPanelForm(this, _authService);
        }
    }
}
