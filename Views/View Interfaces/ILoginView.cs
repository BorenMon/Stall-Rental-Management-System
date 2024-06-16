using System;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface ILoginView
    {
        string PhoneNumber { get; }
        string Password { get; }
        event EventHandler Login;
        void ShowMessage(string message);
    }
}