using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    internal interface IContractView
    {
        // Properties for contract details
        string ContractId { get; set; }
        string FileUrl { get; set; }
        string FileName { get; set; }
        string Code { get; set; }
        string Status { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int StallId { get; set; }
        int StaffId { get; set; }
        int VendorId { get; set; }
        string SeletedFilePath { get; set; }
        //
        // Event to handle contract save button click
        event EventHandler SaveContract;

        // Event to handle contract search button click
        event EventHandler SearchContract;

        // Event to handle contract update button click
        event EventHandler UpdateContract;

        // Event to handle add new contract button click
        event EventHandler AddNewContract;

        // Event to handle downlaod contract button click
        event EventHandler DownloadContract;

        //methods
        void SetContractBindingSource(BindingSource bindingSource);
        // set stall IDs
        void SetStallIdOnComboBox(IEnumerable<int> stallIDs);
        // set vendor IDs
        void SetVendorIdOnComboBox(IEnumerable<int> vendorID);
    }
}
