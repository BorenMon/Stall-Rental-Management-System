using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;


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

        int ContractId { get; set; }

        int StaffId { get; set; }
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
        void SetListBindingSource(BindingSource list);
        void SetContractIdOnComboBox(IEnumerable<Contract> contracts);
    }
}
