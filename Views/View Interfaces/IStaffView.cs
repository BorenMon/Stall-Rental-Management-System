using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IStaffView
    {
        // Properties - Fields
        string StaffId { get; set; }
        string ProfileImageUrl { get; set; }
        string LastNameEn { get; set; }
        string FirstNameEn { get; set; }
        string LastNameKh { get; set; }
        string FirstNameKh { get; set; }
        DateTime BirthDate { get; set; }
        Gender Gender { get; set; }
        string Email { get; set; }
        string Position { get; set; }
        string Address { get; set; }
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
