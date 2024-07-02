using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    internal interface IContractViewForManager
    {
        // Properties for contract details
        string ContractId { get; set; }
        string FileUrl { get; set; }
        string FileName { get; set; }
        string Code { get; set; }
        ContractStatus Status { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int StallId { get; set; }
        int StaffId { get; set; }
        int VendorId { get; set; }
        string SelectedFilePath { get; set; }
        
        bool IsSuccessful { get; set; }

        // Event to handle contract search button click
        event EventHandler SearchContract;
        
        event EventHandler ViewEvent;

        //methods
        void SetContractBindingSource(BindingSource contractList);
        
        // set stall IDs
        void SetStallIdOnComboBox(IEnumerable<int> stallIDs);
        // set vendor IDs
        void SetVendorIdOnComboBox(IEnumerable<int> vendorIDs);
    }
}
