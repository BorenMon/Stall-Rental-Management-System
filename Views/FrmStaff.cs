using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Utils.DesignUtils;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmStaff : Form, IStaffView
    {
        public FrmStaff()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlStaff.TabPages.Remove(tabPageStaffDetail);
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
            buttonAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControlStaff.TabPages.Remove(tabPageStaffList);
                tabControlStaff.TabPages.Add(tabPageStaffDetail);
                tabPageStaffDetail.Text = @"Add new staff";
            };
            
            // Edit
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlStaff.TabPages.Remove(tabPageStaffList);
                tabControlStaff.TabPages.Add(tabPageStaffDetail);
                tabPageStaffDetail.Text = @"Edit staff";
            };
            
            // Save
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful) return;
                tabControlStaff.TabPages.Remove(tabPageStaffDetail);
                tabControlStaff.TabPages.Add(tabPageStaffList);
                MessageBox.Show(Message);
            };
            
            // Save
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlStaff.TabPages.Remove(tabPageStaffDetail);
                tabControlStaff.TabPages.Add(tabPageStaffList);
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
        }

        // Properties
        public string StaffID
        {
            get => textBoxStaffId.Text;
            set => textBoxStaffId.Text = value;
        }
        public string ProfileImageURL
        {
            get => "";
            set { }
        }
        public string LastNameEN
        {
            get => textBoxLastNameEn.Text;
            set => textBoxLastNameEn.Text = value;
        }
        public string FirstNameEN
        {
            get => textBoxFirstNameKh.Text;
            set => textBoxFirstNameKh.Text = value;
        }
        public string LastNameKH
        {
            get => textBoxLastNameKh.Text;
            set => textBoxLastNameKh.Text = value;
        }
        public string FirstNameKH
        {
            get => textBoxFirstNameKh.Text;
            set => textBoxFirstNameKh.Text = value;
        }
        public DateTime BirthDate
        {
            get => new DateTime();
            set { }
        }
        public string Gender
        {
            get => comboBoxGender.Text;
            set => comboBoxGender.Text = value;
        }
        public string Email
        {
            get => textBoxEmail.Text;
            set => textBoxEmail.Text = value;
        }
        public string Position
        {
            get => comboBoxPosition.Text;
            set => comboBoxPosition.Text = value;
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
            set => textBoxPassword.Text = value;
        }
        public string SearchValue 
        { 
            get => textBoxSearch.Text;
            set => textBoxSearch.Text = value;
        }
        public bool IsEdit { get; set; }

        public bool IsSuccessful { get; set; }

        public string Message { get; set; }


        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

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
        
        // Singleton pattern (Open a single form instance)
        private static FrmStaff _instance;

        public static FrmStaff GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FrmStaff();
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }

            return _instance;
        }
    }
}
