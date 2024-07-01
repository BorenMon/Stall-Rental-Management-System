using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Services;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmPayment : Form, IPaymentView
    {
        //
        private DataGridViewCellEventArgs paymentDataGridViewCellEventArgs;
        private DataGridViewCellEventArgs referenceDataGridViewCellEventArgs;
        //
        private OpenFileDialog openFileDialog;
        private int paymentID;
        private string paymentMethod;
        private DateTime paymentDate;
        private string status;
        private string concurrency;
        private decimal amount;
        private int invoiceID;
        //
        public string paymentReferenceImage;
        public string paymentReferenceFileName;
        private readonly AuthenticationService _authService;

        public FrmPayment(AuthenticationService authService)
        {
            InitializeComponent();
            _authService = authService;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set the form's properties to create a fixed size form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            //
            statusComboBox.Items.Add("Paid");
            statusComboBox.Items.Add("CashLess");
            statusComboBox.Items.Add("UnPaid");
            //
            paymentMethodComboBox.Items.Add("Cash");
            paymentMethodComboBox.Items.Add("E-Cash");
            //
            currencyComboBox.Items.Add("Riel");
            currencyComboBox.Items.Add("Dollar");

            // disble
            disableAllComponents();
            // get all data
            new PaymentPresenter(this, new Repositories.PaymentRepository());
            ReloadDatabase();
            searchPaymentTextBox.KeyDown += (e, k) =>
            {
                if (k.KeyCode == Keys.Enter)
                {
                    PaymentID = int.Parse(searchPaymentTextBox.Text);
                    SearchPayment?.Invoke(this, EventArgs.Empty);
                    CheckIsNotFoundPayment();
                    searchPaymentTextBox.Text = "";
                 
                }
                else if (k.KeyCode == Keys.Back)
                {
                    searchPaymentTextBox.Text = "";
                    ReloadDatabase();
                }
            };
        }

        public int PaymentID {
            get => paymentID;
            set => paymentID = value; 
        }
        public string PaymentMethod {
            get => paymentMethod;
            set => paymentMethod = value;
        }
        public DateTime PaymentDate {
            get => paymentDate; 
            set => paymentDate = value;
        }
        public string Status {
            get => status;
            set => status = value;  
        }
        public string Currency { 
            get => concurrency;
            set => concurrency = value;
        }
        public decimal Amount {
            get => amount; 
            set => amount = value;
        }
        public int InvoiceID {
            get => invoiceID; 
            set => invoiceID = value;
        }
        public string ReferenceImgeUrl {
            get => paymentReferenceImage;
            set => paymentReferenceImage = value;
        }
        public string ReferenceFileName {
            get => paymentReferenceFileName; 
            set => paymentReferenceFileName = value;
        }

        public event EventHandler SavePayment;
        public event EventHandler SearchPayment;
        public event EventHandler UpdatePayment;
        public event EventHandler DeletePayment;

        public void setPaymentBinding(BindingSource bindingSource)
        {
            paymentDataGridView.DataSource = bindingSource;
        }

        private async void paymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = paymentDataGridView.Rows[e.RowIndex];
                PaymentID = int.Parse(row.Cells[0].Value.ToString());
                InvoiceID = int.Parse(row.Cells[6].Value.ToString());
                invoiceNoComboBox.Text = InvoiceID.ToString();
                PaymentMethod = row.Cells[1].Value.ToString();
                paymentMethodComboBox.Text = PaymentMethod;
                DateTime.TryParse(row.Cells[2].Value.ToString(), out paymentDate);
                PaymentDate = paymentDate;
                paymentDateTime.Value = paymentDate;
                Status = row.Cells[3].Value.ToString();
                statusComboBox.Text = Status;
                Currency = row.Cells[4].Value.ToString();
                currencyComboBox.Text = Currency;
                Amount =decimal.Parse( row.Cells[5].Value.ToString());
                amountTextBox.Text = Amount.ToString();
                // get reference
                PaymentReferenceModel r =  new PaymentRepository().getPaymentModelReferencePaymentByID(PaymentID);
                referencePictureBox.ImageLocation = await GetPreviewPictureUrlFromMinIOForReference(r.ImageURL); 
                addPaymentReferenceButton.Text = r.FileName;
                //
            }  // set from payment row
            enableAllComponents();
            updateButton.Enabled = true;
            deletePaymentButton.Enabled = true;
            addPaymentReferenceButton.Enabled = false;
            saveButton.Enabled = false;
        }

        private void referencePictureBox_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select an image file
            using (openFileDialog = new OpenFileDialog())
            {
                // Set the initial directory to the Pictures folder
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // If the user selects a file and clicks OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Get the path of the selected file
                         ReferenceImgeUrl  = openFileDialog.FileName;
                        // Load the image into the PictureBox
                        referencePictureBox.Image = new Bitmap(paymentReferenceImage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while uploading the image: " + ex.Message);
                    }
                }
            }
        }

        public void setPaymentReferenceBinding(BindingSource bindingSource)
        {
            paymentReferenceDataGrid.DataSource  = bindingSource;
            
        }
        private void disableAllComponents()
        {
            invoiceNoComboBox.Enabled = false;
            paymentMethodComboBox.Enabled = false;
            paymentDateTime.Enabled = false;
            statusComboBox.Enabled = false;
            amountTextBox.Enabled = false;
            currencyComboBox.Enabled = false;
            referencePictureBox.Enabled = false;
            // button
            saveButton.Enabled = false;
            updateButton.Enabled = false;   
    
            addPaymentReferenceButton.Enabled = false;
            deletePaymentButton.Enabled = false;
        }
        private void enableAllComponents()
        {
            invoiceNoComboBox.Enabled = true;
            paymentMethodComboBox.Enabled = true;
            paymentDateTime.Enabled = true;
            currencyComboBox.Enabled = true;
            saveButton.Enabled = true;
            amountTextBox.Enabled= true;
            statusComboBox.Enabled= true;
            updateButton.Enabled = true;
          
            referencePictureBox.Enabled= true;
            
            deletePaymentButton.Enabled = true;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            clearAllValues();
            enableAllComponents();
            updateButton.Enabled = false;
            addPaymentReferenceButton.Enabled = true;
            addPaymentReferenceButton.Text = "Add File (Doc, PDF)";

            deletePaymentButton .Enabled = false;
        }
        public void setInvoiceID(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
            invoiceNoComboBox.Items.Add(id);

            }
        }

        private bool checkIsPaymentAndReferenceFieldNull()
        {
            if (invoiceNoComboBox.SelectedIndex == 0 ||
                paymentMethodComboBox.SelectedText == "" ||
                statusComboBox.SelectedText == "" ||
                currencyComboBox.SelectedText == "" ||
                amountTextBox.Text == ""
                )
            {
                if (referencePictureBox.ImageLocation == "" ||
                addPaymentReferenceButton.Text == "Add File (Doc, PDF)")
                {
                    MessageBox.Show("Missing Some fields payment reference",
    "Warning", MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(checkIsPaymentAndReferenceFieldNull())
            {
                MessageBox.Show("Missing Some information of payment",
                    "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }else
            {

                PaymentMethod = paymentMethodComboBox.Text;
                DateTime.TryParseExact(paymentDateTime.Text, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out paymentDate);
                PaymentDate = paymentDate;
                Status = statusComboBox.Text;
                Currency = currencyComboBox.Text;
                Amount = int.Parse(amountTextBox.Text);
                InvoiceID = int.Parse(invoiceNoComboBox.Text);
                SavePayment?.Invoke(this, EventArgs.Empty);
                ReloadDatabase();
                clearAllValues();
                addPaymentReferenceButton.Text = "Add File (Doc, PDF)";
            }
        }
        private void ReloadDatabase()
        {
            new PaymentPresenter(this,new Repositories.PaymentRepository(),null);
        }
        private void clearAllValues()
        {
            invoiceNoComboBox.Text = "";
            statusComboBox.Text = "";
            paymentDateTime.Text = "";
            paymentMethodComboBox.Text = "";
            amountTextBox.Text = "";
            currencyComboBox.Text = "";
            referencePictureBox.Image = null;
            ReferenceImgeUrl = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addPaymentReferenceButton.Text =  uploadFileAndPreviewFileName();
        }

        private string uploadFileAndPreviewFileName()
            
        {
            string fileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.doc;*.docx|All Files|*.*"; // Filter to show only PDF and Word files
            openFileDialog.Title = "Select a contract file";

            //
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ReferenceFileName = openFileDialog.FileName;

                // Check if the selected file has a valid extension
                string extension = Path.GetExtension(ReferenceFileName);
                if (extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".doc", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".docx", StringComparison.OrdinalIgnoreCase))
                {
                    // Valid file selected, do something with it
                    // For example, display the seleted file name in a TextBox
                    fileName = Path.GetFileName(ReferenceFileName);
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

        private async void paymentReferenceDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // reference
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = paymentReferenceDataGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells[0].Value.ToString());
                //
                referencePictureBox.ImageLocation = await GetPreviewPictureUrlFromMinIOForReference(row.Cells[1].Value.ToString());
                addPaymentReferenceButton.Text = row.Cells[2].Value.ToString();
                int paymentID = int.Parse(row.Cells[3].Value.ToString());
                //int payID = int.Parse();
            }
            addPaymentReferenceButton.Enabled = false;
           
        }
        public static async Task<string> GetPreviewPictureUrlFromMinIOForReference(string fileName)
        {
            string bucketName = "srms";
            string folderName = "payment"; // Specify the folder name here
            string objectName = $"{folderName}/{fileName}"; // Construct the full object name including the folder
            try
            {
                // Generate a presigned URL for the uploaded file
                string url = await MinIoUtil.GetMinioClient()
                    .PresignedGetObjectAsync(new PresignedGetObjectArgs()
                .WithBucket(bucketName)
                        .WithObject(objectName)
                        .WithExpiry(24 * 60 * 60)); // URL valid for 24 hours
                return url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private void CheckIsNotFoundPayment()
        {
            BindingSource b = (BindingSource)paymentDataGridView.DataSource;
            if (b.Count ==0)
            {
                MessageBox.Show("No Data was found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReloadDatabase();
                return;
            }
        }
        private void SeachButton_Click(object sender, EventArgs e)
        {
            if (searchPaymentTextBox.Text != "")
            {
                PaymentID = int.Parse(searchPaymentTextBox.Text);
                SearchPayment?.Invoke(this, EventArgs.Empty);
                CheckIsNotFoundPayment();
            }
            else
            {
                MessageBox.Show("Please insert payment ID", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void deletePaymentButton_Click(object sender, EventArgs e)
        {
            DeletePayment?.Invoke(this,EventArgs.Empty);
            ReloadDatabase();
            clearAllValues();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            InvoiceID = int.Parse(invoiceNoComboBox.Text);
            PaymentMethod = paymentMethodComboBox.Text;
            PaymentDate = paymentDateTime.Value;
            Status = statusComboBox.Text;
            Amount = decimal.Parse( amountTextBox.Text);
            Currency = currencyComboBox.Text;

            UpdatePayment?.Invoke(this,EventArgs.Empty);
            ReloadDatabase() ;
    
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            GeneralNavigateHelper.NavigateToPanelForm(this, _authService);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUserUtil.Logout(this, _authService);
        }
    }
}
