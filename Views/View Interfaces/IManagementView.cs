using System;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IManagementView
    {
        // Events
        event EventHandler BackToPanelEvent;
        event EventHandler LogoutEvent;
    }
}