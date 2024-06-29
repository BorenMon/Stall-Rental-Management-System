using System;
using System.Drawing;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmVendor : Form, IVendorView
    {
        private OpenFileDialog _openFileDialog;

        private readonly AuthenticationService _authService;

        public event EventHandler SaveVendor;
        public event EventHandler SearchVendor;
        public event EventHandler UpdateVendor;
        public event EventHandler DeleteVendor;

        public FrmVendor(AuthenticationService authService)
        {
            InitializeComponent();
            _authService = authService;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set the form's properties to create a fixed size form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Set to false if you don't want the minimize button
                                     //this.Size = new System.Drawing.Size(1000, 800); // Set your desired form size
                                     //this.MaximumSize = new System.Drawing.Size(800, 600);
                                     //this.MinimumSize = new System.Drawing.Size(800, 600);
                                     //todo table
            var vendorPresenter = new VendorPresenter(this, new VendorRepository());
            ReloadDatabase();
            DisableAllComponents();
            genderComboBox.DataSource = EnumHelper.GetEnumDisplayNames<Gender>();
            genderComboBox.DisplayMember = "Value";
            genderComboBox.ValueMember = "Key";
            //
            DisableAllComponents();
            newButton.Enabled = true;
            //
            searchTextBox.KeyDown += (e, k) =>
            {
                switch (k.KeyCode)
                {
                    case Keys.Enter:
                        VendorId = int.Parse(searchTextBox.Text);
                        SearchVendor?.Invoke(this, EventArgs.Empty);
                        CheckIsNotFoundVendor();
                        searchTextBox.Text = "";
                        break;
                    case Keys.Back:
                        searchTextBox.Text = "";
                        ReloadDatabase();
                        break;
                }
            };
        }

        public int VendorId { get; set; }

        public string FirstNameEn { get; set; }

        public string LastNameEn { get; set; }

        public string FirstNameKh { get; set; }
        public string LastNameKh { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string ProfileUrl { get; set; }

        public string Address { get; set; }

        public void SetVendorBidingSource(BindingSource bindingSource)
        {
            vendorDataGridView.DataSource = bindingSource;
            for (var i = 0; i < 11; i++)
            {
                vendorDataGridView.Columns[i].Width = 150;
            }
        }

        private void uploadProfileButton_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select an image file
            using (_openFileDialog = new OpenFileDialog())
            {
                // Set the initial directory to the Pictures folder
                _openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                _openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                _openFileDialog.FilterIndex = 1;
                _openFileDialog.RestoreDirectory = true;

                // If the user selects a file and clicks OK
                if (_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Get the path of the selected file
                        ProfileUrl =  _openFileDialog.FileName;
                        
                        
                        // Load the image into the PictureBox
                        profileBox.Image = new Bitmap(ProfileUrl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"An error occurred while uploading the image: " + ex.Message);
                    }
                }
            }
        }

        private async void vendorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            EnableAllComponents();
            saveButton.Enabled = false;
            var row = vendorDataGridView.Rows[e.RowIndex];
            VendorId = int.Parse(row.Cells[0].Value.ToString());
            ProfileUrl = row.Cells[1].Value.ToString();
            profileBox.ImageLocation = await VendorPresenter.GetPreviewPictureUrlFromMinIo(ProfileUrl);
            lastNameTextBox.Text = row.Cells[4].Value.ToString();
            firstNameTextBox.Text = row.Cells[3].Value.ToString();
            genderComboBox.Text = row.Cells[8].Value.ToString();
            emailTextBox.Text = row.Cells[9].Value.ToString();
            phoneTextBox.Text = row.Cells[11].Value.ToString();
            passwordTextBox.Text = row.Cells[10].Value.ToString();
            addressTextBox.Text = row.Cells[2].Value.ToString();
        }
        // disable all text field
        private void DisableAllComponents()
        {
            //textBox
            lastNameTextBox.Enabled = false;
            firstNameTextBox.Enabled = false;
            textBoxLastNameKh.Enabled = false;
            textBoxFirstNameKh.Enabled = false;
            dateTimeBirthDate.Enabled = false;
            genderComboBox.Enabled = false;
            emailTextBox.Enabled = false;
            phoneTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            addressTextBox.Enabled = false;
            //button
            uploadProfileButton.Enabled = false;
            saveButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }
        private void EnableAllComponents()
        {
            lastNameTextBox.Enabled = true;
            firstNameTextBox.Enabled = true;
            textBoxLastNameKh.Enabled = true;
            textBoxFirstNameKh.Enabled = true;
            dateTimeBirthDate.Enabled = true;
            genderComboBox.Enabled = true;
            emailTextBox.Enabled = true;
            phoneTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            addressTextBox.Enabled = true;
            uploadProfileButton.Enabled = true;
            saveButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }
        private void ClearAllDataFromTextbox()
        {
            profileBox.Image = null;
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            textBoxLastNameKh.Text = "";
            textBoxFirstNameKh.Text = "";
            dateTimeBirthDate.Value = DateTime.Now.Date;
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            genderComboBox.Text = "";
            phoneTextBox.Text = "";
            addressTextBox.Text = "";
        }
       
        private void searchButton_Click(object sender, EventArgs e)
        {
            VendorId = int.Parse(searchTextBox.Text);
            SearchVendor?.Invoke(this, EventArgs.Empty);
            CheckIsNotFoundVendor();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ClearAllDataFromTextbox();
            EnableAllComponents();
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!CheckIsTextboxEmpty())
            {
                LastNameEn = lastNameTextBox.Text;
                FirstNameEn = firstNameTextBox.Text;
                LastNameKh = textBoxLastNameKh.Text;
                FirstNameKh = textBoxFirstNameKh.Text;
                BirthDate = dateTimeBirthDate.Value;
                Password = passwordTextBox.Text;
                Email = emailTextBox.Text;
                PhoneNumber = phoneTextBox.Text;
                Address = addressTextBox.Text;
                Gender = genderComboBox.Text;
                SaveVendor?.Invoke(this, EventArgs.Empty);
                ReloadDatabase();
                ClearAllDataFromTextbox();
            }
            else
            {
                MessageBox.Show(@"You missed any input field.", @"Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ProfileUrl = null;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (_openFileDialog != null)
            {
                ProfileUrl = _openFileDialog.FileName;
            }
            LastNameEn = lastNameTextBox.Text;
            FirstNameEn = firstNameTextBox.Text;
            LastNameKh = textBoxLastNameKh.Text;
            FirstNameKh = textBoxFirstNameKh.Text;
            BirthDate = dateTimeBirthDate.Value;
            Password = passwordTextBox.Text;
            Email = emailTextBox.Text;
            PhoneNumber = phoneTextBox.Text;
            Address = addressTextBox.Text;
            Gender = genderComboBox.Text;
            UpdateVendor?.Invoke(this, EventArgs.Empty);
            ReloadDatabase();
            ClearAllDataFromTextbox();
            DisableAllComponents();
            newButton.Enabled = true;
            searchButton.Enabled = true;
            ProfileUrl = null;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteVendor?.Invoke(this, EventArgs.Empty);
            ReloadDatabase();
            ClearAllDataFromTextbox();
            DisableAllComponents();
            newButton.Enabled = true;
            searchButton.Enabled = true;
            ProfileUrl = null;

        }
        private void ReloadDatabase()
        {
            vendorDataGridView.DataSource = new VendorPresenter(this, new VendorRepository())
            .ReloadDatabase(new VendorRepository());
        }
        private void CheckIsNotFoundVendor()
        {
            var b = (BindingSource) vendorDataGridView.DataSource;
            if (b.Count != 0) return;
            MessageBox.Show(@"No Data was found!", @"Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ReloadDatabase();
        }
        private bool CheckIsTextboxEmpty()
        {
            return lastNameTextBox.Text == "" ||
                   firstNameTextBox.Text == "" ||
                   emailTextBox.Text == "" ||
                   passwordTextBox.Text == "" ||
                   genderComboBox.Text == "";
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
