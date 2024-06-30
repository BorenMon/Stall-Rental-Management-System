using System;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;


namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    public interface IInvoiceView
    {
        // Properties - Fields
        int InvoiceId { get; set; }
        string InvoiceNo { get; set; }
        DateTime IssuedDate { get; set; }

        decimal RentFee { get; set; }
        
        decimal ElectricityCost { get; set; }

        decimal WaterCost { get; set; }
        
        decimal TotalAmount { get; set; }
        
        InvoiceStatus Status { get; set; }

        string ContractId { get; set; }

        string StaffId { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler ViewEvent;
        event EventHandler AddNewEvent;
        event EventHandler SaveOrUpdateEvent;

        // Methods
        void SetInvoiceListBindingSource(BindingSource list);
    }
}
