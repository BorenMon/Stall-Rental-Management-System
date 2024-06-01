using System;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IStaffView
    {
        // Properties - Fields
        string StaffId { get; set;  }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Gender { get; set; }
        string Email { get; set; }
        string Position { get; set; }
        string PhoneNumber { get; set; }
        string Password { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetStaffListBindingSource(BindingSource staffList);
        void Show(); // Optional
    }
}
