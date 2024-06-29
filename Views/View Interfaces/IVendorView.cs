using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IVendorView
    {
        // Properties - Fields
        string VendorId { get; set; }
        string ProfileImageUrl { set; }
        string LastNameEn { get; set; }
        string FirstNameEn { get; set; }
        string LastNameKh { get; set; }
        string FirstNameKh { get; set; }
        DateTime BirthDate { get; set; }
        Gender Gender { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string Password { get; set; }
        string SearchValue { get; set; }
        bool IsPasswordChanged { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler UploadProfileEvent;
        event EventHandler ViewEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveOrUpdateEvent;

        // Methods
        void SetVendorListBindingSource(BindingSource vendorList);
    }
}