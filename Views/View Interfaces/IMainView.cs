using System;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IMainView
    {
        event EventHandler Load;
        event EventHandler ShowStaffView;
        void ShowLogin();
        void ShowMessage(string message);
        void Close();
    }
}