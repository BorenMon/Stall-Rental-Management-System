using System;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views
{
    public partial class FrmStaff : Form, IStaffView
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        // Properties
        public string StaffID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProfileImageURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastNameEN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstNameEN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastNameKH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstNameKH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetStaffListBindingSource(BindingSource staffList)
        {
            throw new NotImplementedException();
        }
    }
}
