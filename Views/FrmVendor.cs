using Stall_Rental_Management_System.Presenters;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmVendor : Form, IVendorView
    {
        private OpenFileDialog openFileDialog;
        private int vendorId;
        private string profileUrl;
        private string firstNameEN;
        private string lastNameEN;
        private string gender;
        private string email;
        private string password;
        private string phone;
        private string address;

        public event EventHandler SaveVendor;
        public event EventHandler SearchVendor;
        public event EventHandler UpdateVendor;
        public event EventHandler DeleteVendor;

        public FrmVendor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set the form's properties to create a fixed size form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Set to false if you don't want the minimize button
                                     //this.Size = new System.Drawing.Size(1000, 800); // Set your desired form size
                                     //this.MaximumSize = new System.Drawing.Size(800, 600);
                                     //this.MinimumSize = new System.Drawing.Size(800, 600);
                                     //todo table
            new VendorPresenter(this,new VendorRepository());
            ReloadDatabase();
            disableAllComponents();
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            //
            disableAllComponents();
            newButton.Enabled = true;
            //
            searchTextBox.KeyDown += (e, k) =>
            {
                if(k.KeyCode==Keys.Enter)
                {
                    VendorID = int.Parse(searchTextBox.Text);
                    SearchVendor?.Invoke(this, EventArgs.Empty);
                    CheckIsNotFoundVendor();
                    searchTextBox.Text = "";
                }else if (k.KeyCode == Keys.Back)
                {
                    searchTextBox.Text = "";
                    ReloadDatabase();
                }
            };
        }

        public int VendorID {
            get => vendorId;
            set => vendorId = value;
        }
        public string FirstNameEN {
            get => firstNameEN;
            set => firstNameEN = value;
        }
        public string LastNameEN {
            get => lastNameEN;
            set => lastNameEN=value;
        }
        public string FirstNameKH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastNameKH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Gender { 
            get =>gender;
            set => gender= value;
        }
        public string Email {
            get => email;
            set => email = value;
        }
        public string Password {
            get => password;
            set => password = value;
        }
        public string PhoneNumber {
            get => phone;
            set => phone = value;
        }
        public string ProfileUrl {
            get => profileUrl;
            set => profileUrl = value;
        }
        public string Address {
            get => address;
            set => address = value;
        }

        public void setVendorBidingSource(BindingSource bindingSource)
        {
            vendorDataGridView.DataSource = bindingSource;
            for (int i = 0; i < 11; i++)
            {
                vendorDataGridView.Columns[i].Width = 150;

            }
        }

        private void uploadProfileButton_Click(object sender, EventArgs e)
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
                        ProfileUrl =  openFileDialog.FileName;
                        
                        
                        // Load the image into the PictureBox
                        profileBox.Image = new Bitmap(ProfileUrl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while uploading the image: " + ex.Message);
                    }
                }
            }
        }

        private async void vendorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                enableAllComponents();
                saveButton.Enabled = false;
                DataGridViewRow row = vendorDataGridView.Rows[e.RowIndex];
                VendorID = int.Parse(row.Cells[0].Value.ToString());
                ProfileUrl = row.Cells[1].Value.ToString();
                profileBox.ImageLocation = await VendorPresenter.GetPreviewPictureUrlFromMinIO(ProfileUrl);
                lastNameTextBox.Text = row.Cells[4].Value.ToString();
                firstNameTextBox.Text = row.Cells[3].Value.ToString();
                genderComboBox.Text = row.Cells[8].Value.ToString();
                emailTextBox.Text = row.Cells[9].Value.ToString();
                phoneTextBox.Text = row.Cells[11].Value.ToString();
                passwordTextBox.Text = row.Cells[10].Value.ToString();
                addressTextBox.Text = row.Cells[2].Value.ToString();
            }
        }
        // disable all text field
        private void disableAllComponents()
        {
            //textBox
            lastNameTextBox.Enabled = false;
            firstNameTextBox.Enabled = false;
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
        private void enableAllComponents()
        {
            lastNameTextBox.Enabled = true;
            firstNameTextBox.Enabled = true;
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
        private void clearAllDataFromTextbox()
        {
            profileBox.Image = null;
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            genderComboBox.Text = "";
            phoneTextBox.Text = "";
            addressTextBox.Text = "";
        }
       
        private void searchButton_Click(object sender, EventArgs e)
        {
            VendorID = int.Parse(searchTextBox.Text);
            SearchVendor?.Invoke(this, EventArgs.Empty);
            CheckIsNotFoundVendor();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            clearAllDataFromTextbox();
            enableAllComponents();
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!CheckIsTextboxEmpty())
            {
                LastNameEN = lastNameTextBox.Text;
                FirstNameEN = firstNameTextBox.Text;
                Password = passwordTextBox.Text;
                Email = emailTextBox.Text;
                PhoneNumber = phoneTextBox.Text;
                Address = addressTextBox.Text;
                Gender = genderComboBox.Text;
                SaveVendor?.Invoke(this, EventArgs.Empty);
                ReloadDatabase();
                clearAllDataFromTextbox();
            }
            else
            {
                MessageBox.Show("You missed any input field.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ProfileUrl = null;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog != null)
            {
                ProfileUrl = openFileDialog.FileName;
            }
            LastNameEN = lastNameTextBox.Text;
            FirstNameEN = firstNameTextBox.Text;
            Password = passwordTextBox.Text;
            Email = emailTextBox.Text;
            PhoneNumber = phoneTextBox.Text;
            Address = addressTextBox.Text;
            Gender = genderComboBox.Text;
            UpdateVendor?.Invoke(this, EventArgs.Empty);
            ReloadDatabase();
            clearAllDataFromTextbox();
            disableAllComponents();
            newButton.Enabled = true;
            searchButton.Enabled = true;
            ProfileUrl = null;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteVendor?.Invoke(this, EventArgs.Empty);
            ReloadDatabase();
            clearAllDataFromTextbox();
            disableAllComponents();
            newButton.Enabled = true;
            searchButton.Enabled = true;
            ProfileUrl = null;

        }
        private void ReloadDatabase()
        {
            vendorDataGridView.DataSource = new VendorPresenter()
            .ReloadDatabase(new VendorRepository());
        }
        private void CheckIsNotFoundVendor()
        {
            BindingSource b = (BindingSource) vendorDataGridView.DataSource;
            if (b.Count == 0)
            {
                MessageBox.Show("No Data was found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReloadDatabase();
            }
        }
        private Boolean CheckIsTextboxEmpty()
        {
            if (lastNameTextBox.Text == "" ||
               firstNameTextBox.Text == "" ||
               emailTextBox.Text == ""||
               passwordTextBox.Text == ""||
               genderComboBox.Text == "")
            {
                return true;
            }
            return false;
        }
    }
}
