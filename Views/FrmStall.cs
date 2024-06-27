using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

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
    public partial class FrmStall : Form, IStallView
    {
        private StallPresenter _presenter;
        private readonly AuthenticationService _authService;

        public ListBox ImageListBox => listBoxImagesFileName;
        public PictureBox ImagePictureBox => pictureBoxImage;
        public Button AddImageButton => buttonAddImage;
        public Button RemoveImageButton => buttonRemoveImage;
        public OpenFileDialog OpenFileDialog => openFileDialog;

        public FrmStall(StallRepository stallRepository, AuthenticationService authService)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            _authService = authService;
            _presenter = new StallPresenter(this, stallRepository);

            Customize();
        }

        private void Customize()
        {
            panelDetail.Enabled = false;

            // Assuming comboBoxType is your ComboBox control
            comboBoxType.DisplayMember = "DisplayName";
            comboBoxType.ValueMember = "Value";
            comboBoxType.Items.Add(new { DisplayName = "Select", Value = string.Empty });

            // Add other items
            foreach (StallType stallType in Enum.GetValues(typeof(StallType)))
            {
                comboBoxType.Items.Add(new { DisplayName = EnumHelper.GetDisplayName(stallType), Value = stallType.ToString() });
            }

            // Set the selected item
            comboBoxType.SelectedIndex = 0; // Select the "Select" item by default

            textBoxSize.KeyPress += FloatOrDecimalValidationHelper.KeyPress;
            textBoxMonthlyFee.KeyPress += FloatOrDecimalValidationHelper.KeyPress;

            OpenFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;

            ImagePictureBox.LoadCompleted += (sender, e) =>
            {
                if (e.Error != null)
                {
                    // Error loading the image, set a default error image
                    ImagePictureBox.ImageLocation = MinIoUtil.GenerateFileUrl("error_image.png", "srms");
                }
            };
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
                panelImages.Enabled = false;
                buttonUpdateOrSave.Text = @"Save";
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
                    panelImages.Enabled = false;
                    ImagePictureBox.ImageLocation = null;
                    ImageListBox.DataSource = null;
                }
                MessageBox.Show(Message);
            };

            // View
            dataGridViewStall.CellClick += delegate
            {
                panelImages.Enabled = true;
                buttonUpdateOrSave.Text = @"Update";
                panelDetail.Enabled = true;
                ViewEvent?.Invoke(this, EventArgs.Empty);
            };
            
            // Delete
            buttonDeleteStall.Click += delegate
            {
                var result = MessageBox.Show(
                    @"Are you sure you want to delete the selected stall?",
                    @"Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes) return;
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

            // Add Image
            buttonAddImage.Click += delegate { AddImageEvent?.Invoke(this, EventArgs.Empty); };
            buttonRemoveImage.Click += delegate { RemoveImageEvent?.Invoke(this, EventArgs.Empty); };
            listBoxImagesFileName.SelectedIndexChanged += delegate { SelectImageEvent?.Invoke(this, EventArgs.Empty); };

            // Back to panel
            buttonBack.Click += (sender, args) => GeneralNavigateHelper.NavigateToPanelForm(this, _authService);
            // Logout
            buttonLogout.Click += (sender, args) => CurrentUserUtil.Logout(this, _authService);
        }

        public int StallId { get; set; }

        public string Code
        {
            get => textBoxCode.Text; 
            set => textBoxCode.Text = value;
        }

        public StallStatus Status
        {
            get => EnumHelper.TryGetEnumValueFromDisplayName<StallStatus>(textBoxStatus.Text, out var status) ? status : default;
            set => textBoxStatus.Text = EnumHelper.GetDisplayName(value);
        }

        public string Type
        {
            get
            {
                var selected = comboBoxType.SelectedItem;
                return (string)selected.GetType().GetProperty("Value").GetValue(selected);
            }
            set
            {
                if (Enum.TryParse(value, out StallType stallType))
                {
                    foreach (var item in comboBoxType.Items)
                    {
                        if ((string)item.GetType().GetProperty("Value").GetValue(item) == value)
                        {
                            comboBoxType.SelectedItem = item;
                            return;
                        }
                    }
                }
                else
                {
                    comboBoxType.SelectedIndex = 0;
                }
            }
        }

        public float StallSize
        {
            get =>
                float.TryParse(textBoxSize.Text, out var size) ? size : 0;
            set => textBoxSize.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public decimal MonthlyFee
        {
            get => decimal.TryParse(textBoxMonthlyFee.Text, out var size) ? size : 0;
            set => textBoxMonthlyFee.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public string StallLocation
        {
            get => textBoxLocation.Text; 
            set => textBoxLocation.Text = value;
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
        public event EventHandler DeleteEvent;
        public event EventHandler SaveOrUpdateEvent;
        public event EventHandler SelectImageEvent;
        public event EventHandler AddImageEvent;
        public event EventHandler RemoveImageEvent;

        public void SetStallListBindingSource(BindingSource stallList)
        {
            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("Code", "Code"),
                ("ConvertedStatus", "Status"),
                ("ConvertedType", "Type"),
                ("MonthlyFee", "Monthly Fee")
            };

            DataGridViewHelper.SetDataGridViewColumns(dataGridViewStall, stallList, columns);
        }
    }
}