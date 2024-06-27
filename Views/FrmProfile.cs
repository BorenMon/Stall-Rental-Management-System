using System;
using System.Windows.Forms;

using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.DesignHelpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Views
{
    public partial class FrmProfile : Form
    {
        private readonly ProfilePresenter _presenter;
        private readonly AuthenticationService _authService;
        private readonly User _user;
        public string CurrentProfileImageObjectName { get; private set; }

        public FrmProfile(AuthenticationService authService)
        {
            InitializeComponent();
            _presenter = new ProfilePresenter(this);

            _authService = authService;
            _user = CurrentUserUtil.User;

            Customize();
            InitUser();
            AssociateAndRaiseViewEvents();
        }
        
        private void Customize()
        {
            comboBoxGender.DataSource = EnumHelper.GetEnumDisplayNames<Gender>();
            comboBoxGender.DisplayMember = "Value";
            comboBoxGender.ValueMember = "Key";
            
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

        private void InitUser()
        {
            ProfileImageUrl = _user.ProfileImageUrl;
            LastNameKh = _user.LastNameKh;
            FirstNameKh = _user.FirstNameKh;
            LastNameEn = _user.LastNameEn;
            FirstNameEn = _user.FirstNameEn;
            BirthDate = _user.BirthDate;
            Gender = _user.Gender;
            Email = _user.Email;
            Address = _user.Address;
            PhoneNumber = _user.PhoneNumber;
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Upload Profile
            buttonUploadProfile.Click += UploadProfile;
            
            // Update Profile
            buttonUpdate.Click += UpdateProfile;
            
            // Change Password
            buttonChangePassword.Click += ChangePassword;
            
            // Back to panel
            buttonBack.Click += (sender, args) => GeneralNavigateHelper.NavigateToPanelForm(this, _authService);
            // Logout
            buttonLogout.Click += (sender, args) => CurrentUserUtil.Logout(this, _authService);
        }

        private static void ChangePassword(object sender, EventArgs e)
        {
            using (var changePasswordForm = new FrmChangePassword())
            {
                changePasswordForm.ShowDialog();
            }
        }

        private void UpdateProfile(object sender, EventArgs e)
        {
            _presenter.Update();
            MessageBox.Show(Message);
        }

        private async void UploadProfile(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                var selectedFileName = openFileDialog.FileName;

                // Compress the image before uploading
                var compressedFileStream = ImageHelper.CompressImage(selectedFileName);

                var objectName = "profile/" + MinIoUtil.GenerateRandomObjectName("profile", 15);
                var contentType = MinIoUtil.GetContentType(selectedFileName);
                const string bucketName = "srms";

                MinIoUtil.InitMinioClient();
                await MinIoUtil.UploadFileAsync(objectName, compressedFileStream, contentType, bucketName);

                CurrentProfileImageObjectName = objectName;
                ProfileImageUrl = objectName;
            }
        }
        
        public string Message { get; set; }

        public string ProfileImageUrl
        {
            get => CurrentProfileImageObjectName;
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
            private set => textBoxLastNameEn.Text = value;
        }
        public string FirstNameEn
        {
            get => textBoxFirstNameEn.Text;
            private set => textBoxFirstNameEn.Text = value;
        }
        public string LastNameKh
        {
            get => textBoxLastNameKh.Text;
            private set => textBoxLastNameKh.Text = value;
        }
        public string FirstNameKh
        {
            get => textBoxFirstNameKh.Text;
            private set => textBoxFirstNameKh.Text = value;
        }
        public DateTime BirthDate
        {
            get => dateTimeBirthDate.Value;
            private set => dateTimeBirthDate.Value = value;
        }
        public Gender Gender
        {
            get => (Gender)comboBoxGender.SelectedValue;
            private set => comboBoxGender.SelectedValue = value;
        }
        public string Email
        {
            get => textBoxEmail.Text;
            private set => textBoxEmail.Text = value;
        }
        public string Address
        {
            get => richTextBoxAddress.Text;
            private set => richTextBoxAddress.Text = value;
        }
        public string PhoneNumber
        {
            get => textBoxPhoneNumber.Text;
            private set => textBoxPhoneNumber.Text = value;
        }
    }
}
