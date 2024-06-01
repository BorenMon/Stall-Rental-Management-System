using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views.Supermarket_Staff_Forms
{
    public partial class FrmStaff : Form, IStaffView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public FrmStaff()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlStaff.TabPages.Remove(tabPageStaffDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Others
        }

        // Properties
        public string StaffID
        {
            get { return textBoxStaffId.Text; }
            set { textBoxStaffId.Text = value; }
        }
        public string ProfileImageURL
        {
            get { return ""; }
            set { }
        }
        public string LastNameEN
        {
            get { return textBoxLastNameEn.Text; }
            set { textBoxLastNameEn.Text = value; }
        }
        public string FirstNameEN
        {
            get { return textBoxFirstNameKh.Text; }
            set { textBoxFirstNameKh.Text = value; }
        }
        public string LastNameKH
        {
            get { return textBoxLastNameKh.Text; }
            set { textBoxLastNameKh.Text = value; }
        }
        public string FirstNameKH
        {
            get { return textBoxFirstNameKh.Text; }
            set { textBoxFirstNameKh.Text = value; }
        }
        public DateTime BirthDate
        {
            get { return new DateTime(); }
            set { }
        }
        public string Gender
        {
            get { return comboBoxGender.Text; }
            set { comboBoxGender.Text = value; }
        }
        public string Email
        {
            get { return textBoxEmail.Text; }
            set { textBoxEmail.Text = value; }
        }
        public string Position
        {
            get { return comboBoxPosition.Text; }
            set { comboBoxPosition.Text = value; }
        }
        public string Address
        {
            get { return richTextBoxAddress.Text; }
            set { richTextBoxAddress.Text = value; }
        }
        public string PhoneNumber
        {
            get { return textBoxPhoneNumber.Text; }
            set { textBoxPhoneNumber.Text = value; }
        }
        public string Password
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }
        public string SearchValue 
        { 
            get { return textBoxSearch.Text; }
            set { textBoxSearch.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        { 
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; }
        }


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
            dataGridViewStaff.DataSource = staffList;
        }
    }
}
