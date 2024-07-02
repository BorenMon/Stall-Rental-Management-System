using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.DesignHelpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;


namespace Stall_Rental_Management_System.Views
{
    public partial class FrmInvoice : Form, IInvoiceView
    {
        private InvoicePresenter _presenter;
        private readonly AuthenticationService _authService;
        private IEnumerable<Contract> _contracts;

        public FrmInvoice(InvoiceRepository repository, AuthenticationService authService)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            _authService = authService;
            _presenter = new InvoicePresenter(this, repository);

            Customize();
        }

        private void Customize()
        {
            comboBoxStatus.DataSource = EnumHelper.GetEnumDisplayNames<InvoiceStatus>();
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";

            panelDetail.Enabled = false;

            textBoxElectricCost.KeyPress += FloatOrDecimalValidationHelper.KeyPress;
            textBoxWaterCost.KeyPress += FloatOrDecimalValidationHelper.KeyPress;
            textBoxRentFee.KeyPress += FloatOrDecimalValidationHelper.KeyPress;
            textBoxTotalAmount.KeyPress += FloatOrDecimalValidationHelper.KeyPress;
            
            // Subscribe to TextChanged event
            textBoxRentFee.TextChanged += (s, e) => CalculateTotalAmount();
            textBoxElectricCost.TextChanged += (s, e) => CalculateTotalAmount();
            textBoxWaterCost.TextChanged += (s, e) => CalculateTotalAmount();
            
            comboBoxContractCode.SelectedIndexChanged += (s, e) => ChangeRentFee();
            
            // Set the ComboBox to allow user input for searching
            comboBoxContractCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxContractCode.AutoCompleteSource = AutoCompleteSource.ListItems;

            dateTimeIssuedDate.Enabled = false;
        }

        private void ChangeRentFee()
        {
            // Check if an item is selected
            if (comboBoxContractCode.SelectedItem != null)
            {
                // Get the selected contract's ID
                var selectedContractId = ((KeyValuePair<int, string>)comboBoxContractCode.SelectedItem).Key;

                // Find the contract in _contracts by ID
                var selectedContract = _contracts.FirstOrDefault(c => c.Id == selectedContractId);

                // Update textBoxRentFee.Text with RentFee if contract is found
                textBoxRentFee.Text = selectedContract != null ? selectedContract.RentFee.ToString(CultureInfo.InvariantCulture) : // Assuming textBoxRentFee is for displaying RentFee
                    ""; // Handle case when no contract is found (optional)
            }
            else
            {
                textBoxRentFee.Text = ""; // Handle case when no item is selected (optional)
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Add new
            buttonAddNewStall.Click += delegate
            {
                buttonUpdateOrSave.Text = @"Save";
                comboBoxContractCode.Enabled = true;
                buttonUpdateOrSave.Enabled = true;
                panelDetail.Enabled = true;
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };

            // Save
            buttonUpdateOrSave.Click += delegate
            {
                SaveOrUpdateEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    panelDetail.Enabled = false;
                }
                MessageBox.Show(Message);
            };

            // View
            dataGridViewInvoice.CellClick += delegate
            {
                buttonUpdateOrSave.Text = @"Update";
                comboBoxContractCode.Enabled = false;
                panelDetail.Enabled = true;
                ViewEvent?.Invoke(this, EventArgs.Empty);
                buttonUpdateOrSave.Enabled = CurrentUserUtil.User.UserId == StaffId;
            };

            // Back to panel
            buttonBack.Click += (sender, args) => GeneralNavigateHelper.NavigateToPanelForm(this, _authService);
            // Logout
            buttonLogout.Click += (sender, args) => CurrentUserUtil.Logout(this, _authService);

            // Print button click event
            buttonPrint.Click += (sender, e) =>
            {
                if (dataGridViewInvoice.CurrentRow != null)
                {
                    Invoice = (InvoiceModel)dataGridViewInvoice.CurrentRow.DataBoundItem;
                    printPreviewDialog.Document = printDocument;
                    printDocument.DefaultPageSettings.PaperSize = new PaperSize("Invoice", 850, 1100); // Adjust size as needed
                    printPreviewDialog.StartPosition = FormStartPosition.CenterParent;
                    printPreviewDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"Please select an invoice to print.");
                }
            };
        }
        
        public void SetContractIdOnComboBox(IEnumerable<Contract> contracts)
        {
            var enumerable = contracts.ToList();
            _contracts = enumerable;
            comboBoxContractCode.Items.Clear();
            foreach (var contract in enumerable)
            {
                comboBoxContractCode.Items.Add(new KeyValuePair<int, string>(contract.Id, $"{contract.Code} ({EnumHelper.ConvertToReadableFormat(contract.Status.ToString())})"));
            }
            comboBoxContractCode.DisplayMember = "Value";
            comboBoxContractCode.ValueMember = "Key";
        }

        public int InvoiceId { get; set; }

        public string InvoiceNo
        {
            get => textBoxInvoiceNo.Text; 
            set => textBoxInvoiceNo.Text = value;
        }

        public DateTime IssuedDate
        {
            get => dateTimeIssuedDate.Value; 
            set => dateTimeIssuedDate.Value = value;
        }
        
        private void CalculateTotalAmount()
        {
            TotalAmount = RentFee + WaterCost + ElectricityCost;
        }

        public decimal RentFee
        {
            get => decimal.TryParse(textBoxRentFee.Text, out var size) ? size : 0;
            set => textBoxRentFee.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public decimal ElectricityCost
        {
            get => decimal.TryParse(textBoxElectricCost.Text, out var size) ? size : 0;
            set => textBoxElectricCost.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public decimal WaterCost
        {
            get => decimal.TryParse(textBoxWaterCost.Text, out var size) ? size : 0;
            set => textBoxWaterCost.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public decimal TotalAmount
        {
            get => decimal.TryParse(textBoxTotalAmount.Text, out var size) ? size : 0;
            set => textBoxTotalAmount.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public InvoiceStatus Status
        {
            get => (InvoiceStatus)comboBoxStatus.SelectedValue;
            set => comboBoxStatus.SelectedValue = (int)value;
        }

        public int ContractId
        {
            get => comboBoxContractCode.SelectedItem is KeyValuePair<int, string> selectedPair ? selectedPair.Key : 0;
            set
            {
                // Find the item with the matching key and set it as selected
                foreach (KeyValuePair<int, string> item in comboBoxContractCode.Items)
                {
                    if (item.Key != value) continue;
                    comboBoxContractCode.SelectedItem = item;
                    return; // Exit once found and selected
                }

                // If value is 0 or not found, set a default or empty text
                comboBoxContractCode.SelectedItem = null; // Clear selection
                comboBoxContractCode.Text = @"Select Contract"; // Set default or empty text
            }
        }

        public int StaffId
        {
            get => int.Parse(textBoxStaffID.Text);
            set => textBoxStaffID.Text = value.ToString();
        }

        public string SearchValue
        {
            get => textBoxSearch.Text; 
            set => textBoxSearch.Text = value;
        }
        
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler ViewEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SaveOrUpdateEvent;

        public void SetListBindingSource(BindingSource stallList)
        {
            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("InvoiceNo", "Invoice No"),
                ("ContractId", "Contract ID"),
                ("IssuedDate", "Issued Date"),
                ("TotalAmount", "Total Amount"),
                ("Status", "Status")
            };

            DataGridViewHelper.SetDataGridViewColumns(dataGridViewInvoice, stallList, columns);
        }

        public InvoiceModel Invoice { get; set; }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (Invoice != null)
            {
                var fontTitle = new Font("Poppins", 14, FontStyle.Bold);
                var fontHeader = new Font("Poppins", 12, FontStyle.Bold);
                var fontContent = new Font("Poppins", 12);
                var brush = Brushes.Black;
                var leftMargin = e.MarginBounds.Left;
                var topMargin = e.MarginBounds.Top;

                // Title
                e.Graphics.DrawString("Invoice", fontTitle, brush, leftMargin, topMargin);

                // Invoice Number
                e.Graphics.DrawString("Invoice No:", fontHeader, brush, leftMargin, topMargin + 40);
                e.Graphics.DrawString(Invoice.InvoiceNo, fontContent, brush, leftMargin + 150, topMargin + 40);

                // Issued Date
                e.Graphics.DrawString("Issued Date:", fontHeader, brush, leftMargin, topMargin + 70);
                e.Graphics.DrawString(Invoice.IssuedDate.ToString("dd MMMM yyyy"), fontContent, brush, leftMargin + 150, topMargin + 70);

                // Rent Fee
                e.Graphics.DrawString("Rent Fee:", fontHeader, brush, leftMargin, topMargin + 100);
                e.Graphics.DrawString($"${Invoice.RentFee:F2}", fontContent, brush, leftMargin + 150, topMargin + 100);

                // Electricity Cost
                e.Graphics.DrawString("Electricity Cost:", fontHeader, brush, leftMargin, topMargin + 130);
                e.Graphics.DrawString($"${Invoice.ElectricityCost:F2}", fontContent, brush, leftMargin + 150, topMargin + 130);

                // Water Cost
                e.Graphics.DrawString("Water Cost:", fontHeader, brush, leftMargin, topMargin + 160);
                e.Graphics.DrawString($"${Invoice.WaterCost:F2}", fontContent, brush, leftMargin + 150, topMargin + 160);

                // Total Amount
                e.Graphics.DrawString("Total Amount:", fontHeader, brush, leftMargin, topMargin + 190);
                e.Graphics.DrawString($"${Invoice.TotalAmount:F2}", fontContent, brush, leftMargin + 150, topMargin + 190);

                // Status
                e.Graphics.DrawString("Status:", fontHeader, brush, leftMargin, topMargin + 220);
                e.Graphics.DrawString(Invoice.Status.ToString(), fontContent, brush, leftMargin + 150, topMargin + 220);

                // Draw a border
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(leftMargin, topMargin + 30, e.MarginBounds.Width - 20, 210));
            }
            else
            {
                MessageBox.Show(@"Please click any invoice in the data grid first before printing");
            }
        }
    }
}