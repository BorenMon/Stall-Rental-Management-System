using Stall_Rental_Management_System.Enums;


namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface ILoginView
    {
        string PhoneNumber { get; }
        string Password { get; }
        UserType SelectedUserType { get; }
        void ShowMessage(string message);
        void NavigateToVendorPanel();
        void NavigateToStaffPanel();
        void NavigateToManagerPanel();
        void Close();
    }
}