using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.DesignHelpers;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;


namespace Stall_Rental_Management_System.Views
{
    public partial class FrmStaff : Form, IStaffView, IManagementView
    {
        private StaffPresenter _presenter;
        private readonly AuthenticationService _authService;
        public string CurrentProfileImageObjectName { get; set; }
        
        public FrmStaff(StaffRepository staffRepository, AuthenticationService authService)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            _authService = authService;
            
            // Initialize the presenter
            _presenter = new StaffPresenter(this, staffRepository, authService);

            Customize();
        }

        private void Customize()
        {
            comboBoxGender.DataSource = EnumHelper.GetEnumDisplayNames<Gender>();
            comboBoxGender.DisplayMember = "Value";
            comboBoxGender.ValueMember = "Key";

            panelDetail.Enabled = false;
            
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            
            pictureBoxProfile.LoadCompleted += (sender, e) =>
            {
                if (e.Error != null)
                {
                    // Error loading the image, set a default error image
                    pictureBoxProfile.ImageLocation = MinIoUtil.GenerateFileUrl("error_image.png", "srms");
                }
            };
            
            textBoxPhoneNumber.KeyPress += (sender, e) =>
            {
                var textBox = (TextBox)sender;
                PhoneNumberValidationHelper.ValidateKeypress(textBox, e);
            };
            textBoxPhoneNumber.TextChanged += (sender, e) =>
            {
                var textBox = (TextBox)sender;
                PhoneNumberValidationHelper.ValidatePaste(textBox);
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
            
            // Upload Profile
            buttonUploadProfile.Click += delegate
            {
                UploadProfileEvent?.Invoke(this, EventArgs.Empty);
            };
            
            // Change password
            textBoxPassword.TextChanged += delegate
            {
                PasswordChangedEvent?.Invoke(this, EventArgs.Empty);
            };
            
            // View
            dataGridViewStaff.CellClick += delegate
            {
                buttonUpdateOrSave.Text = @"Update";
                panelDetail.Enabled = true;
                ViewEvent?.Invoke(this, EventArgs.Empty);
            };

            // Add new
            buttonAddNew.Click += delegate
            {
                buttonUpdateOrSave.Text = @"Save";
                panelDetail.Enabled = true;
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };
            
            // Save
            buttonUpdateOrSave.Click += delegate
            {
                SaveOrUpdateEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful) return;
                panelDetail.Enabled = false;
                MessageBox.Show(Message);
            };
            
            // Delete
            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    @"Are you sure you want to delete the selected staff?",
                    @"Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes) return;
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            
            // Back to panel
            buttonBack.Click += delegate { BackToPanelEvent?.Invoke(this, EventArgs.Empty); };
            
            // Logout
            buttonLogout.Click += (sender, args) => CurrentUserUtil.Logout(this, _authService);
        }

        // Properties
        public string StaffId
        {
            get => textBoxStaffId.Text;
            set => textBoxStaffId.Text = value;
        }
        public string ProfileImageUrl
        {
            set
            {
                CurrentProfileImageObjectName = value;
                var imageLocation = value != string.Empty
                    ? MinIoUtil.GenerateFileUrl(value, "srms")
                    : null;
                pictureBoxProfile.ImageLocation = string.IsNullOrEmpty(imageLocation) ? MinIoUtil.GenerateFileUrl("profile/null_profile.png", "srms") : imageLocation;
            }
        }

        public string LastNameEn
        {
            get => textBoxLastNameEn.Text;
            set => textBoxLastNameEn.Text = value;
        }
        public string FirstNameEn
        {
            get => textBoxFirstNameEn.Text;
            set => textBoxFirstNameEn.Text = value;
        }
        public string LastNameKh
        {
            get => textBoxLastNameKh.Text;
            set => textBoxLastNameKh.Text = value;
        }
        public string FirstNameKh
        {
            get => textBoxFirstNameKh.Text; 
            set => textBoxFirstNameKh.Text = value;
        }
        public DateTime BirthDate
        {
            get => dateTimeBirthDate.Value;
            set => dateTimeBirthDate.Value = value;
        }
        public Gender Gender
        {
            get => (Gender)comboBoxGender.SelectedValue;
            set => comboBoxGender.SelectedValue = value;
        }
        public string Email
        {
            get => textBoxEmail.Text;
            set => textBoxEmail.Text = value;
        }
        public StaffPosition Position
        {
            get
            {
                Enum.TryParse(textBoxPosition.Text, out StaffPosition position);
                return position;
            }
            set => textBoxPosition.Text = EnumHelper.GetDisplayName(value);
        }
        public string Address
        {
            get => richTextBoxAddress.Text;
            set => richTextBoxAddress.Text = value;
        }
        public string PhoneNumber
        {
            get => textBoxPhoneNumber.Text;
            set => textBoxPhoneNumber.Text = value;
        }
        public string Password
        {
            get => textBoxPassword.Text;
            set
            {
                IsPasswordChanged = false; // Reset the flag when setting the password from the database
                textBoxPassword.Text = value;
            }
        }
        public string SearchValue 
        { 
            get => textBoxSearch.Text;
            set => textBoxSearch.Text = value;
        }

        public bool IsPasswordChanged { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }


        // Events
        public event EventHandler SearchEvent;
        public event EventHandler UploadProfileEvent;
        public event EventHandler PasswordChangedEvent;
        public event EventHandler ViewEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveOrUpdateEvent;
        public event EventHandler BackToPanelEvent;

        // Methods
        public void SetStaffListBindingSource(BindingSource staffList)
        {
            var columns = new List<(string DataPropertyName, string HeaderText, string Name)>
            {
                ("StaffId", "Staff ID", "StaffIdColumn"),
                ("FullNameKh", "Full Name KH", "FullNameKhColumn"),
                ("FullNameEn", "Full Name EN", "FullNameEnColumn"),
                ("Position", "Position", "PositionColumn"),
                ("PhoneNumber", "PhoneNumber", "PhoneNumberColumn"),
            };

            DataGridViewHelper.SetDataGridViewColumns(dataGridViewStaff, staffList, columns);
        }
    }
}
