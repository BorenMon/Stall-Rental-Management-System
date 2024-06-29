using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IStallViewForManager
    {
        // Properties - Fields
        int StallId { get; set; }
        string Code { get; set; }
        StallStatus Status { get; set; }
        string Type { get; set; }
        float StallSize { get; set; }
        decimal MonthlyFee { get; set; }
        string StallLocation { get; set; }
        
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler ViewEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveOrUpdateEvent;

        // Methods
        void SetStallListBindingSource(BindingSource stallList);

        ListBox ImageListBox { get; }
        PictureBox ImagePictureBox { get; }
        Button AddImageButton { get; }
        Button RemoveImageButton { get; }
        OpenFileDialog OpenFileDialog { get; }
    }
}
