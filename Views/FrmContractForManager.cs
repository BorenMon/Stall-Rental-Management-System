using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Minio.DataModel.Args;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.DesignHelpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmContractForManager : Form, IContractViewForManager
    {
        private readonly ToolTip _toolTip = new ToolTip();
        private readonly AuthenticationService _authService;

        public FrmContractForManager(AuthenticationService authService)
        {
            InitializeComponent();
            _authService = authService;
            //adding title for each button do
            _toolTip.SetToolTip(downloadButton, "Click to download contract as file");
            _toolTip.SetToolTip(logoutButton, "Logout");

            //disable button
            downloadButton.Enabled = false;

            //making form to be center write below statement in form constructor
            StartPosition = FormStartPosition.CenterScreen;
            //
            // Set the form's properties to create a fixed size form
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = true;
            var contractPresenter = new ContractPresenterForManager(this, new ContractRepository());


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
            set => contractStatusComboBox.SelectedValue = (int)value;
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
        
        public event EventHandler SearchContract;
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

        private void contractDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contractCodeText.ReadOnly = true;
            
            ViewEvent?.Invoke(this, EventArgs.Empty);
            contractStatusComboBox.Enabled = Status != ContractStatus.CLOSED;

            contractStallIDComboBox.Enabled = false;
            contractVendorIDComboBox.Enabled = false;
            downloadButton.Enabled = true;
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

        public bool IsSuccessful { get; set; }
        
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