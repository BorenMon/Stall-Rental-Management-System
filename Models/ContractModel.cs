using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    internal class ContractModel
    {
        // field
        private int contractID;
        private string fileUrl;
        private string code;
        private string status;
        private DateTime startDate;
        private DateTime endDate;
        // Relationship fields
        private int stallID;
        private int staffID;
        private int vendorID;
        //
        // Relationship fields
        private int stallId;
        private int staffId;
        private int vendorId;

        // Relationships
        //private StallModel stall;
        //private StaffModel staff;
        //private VendorModel vendor;

        // Properties
        [DisplayName("Contract ID")]
        [Required(ErrorMessage ="Contract ID is required")]
        public int Id
        {
            get { return contractID; }
            set { contractID = value; }
        }

        [StringLength(255)]
        public string FileUrl
        {
            get { return fileUrl; }
            set { fileUrl = value; }
        }
        [StringLength(8)]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        [Required(ErrorMessage ="Stall ID is required.")]
        public int StallId
        {
            get { return stallId; }
            set { stallId = value; }
        }
        [Required(ErrorMessage = "Staff ID is required.")]

        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }
        [Required(ErrorMessage = "Vendor ID is required.")]
        public int VendorId
        {
            get { return vendorId; }
            set { vendorId = value; }
        }

        //public StallModel Stall
        //{
        //    get { return stall; }
        //    set { stall = value; }
        //}

        //public StaffModel Staff
        //{
        //    get { return staff; }
        //    set { staff = value; }
        //}

        //public VendorModel Vendor
        //{
        //    get { return vendor; }
        //    set { vendor = value; }
        //}

        // Constructor
        public ContractModel() { }
        public ContractModel(int contractID, string fileUrl, string code, string status, DateTime startDate, DateTime endDate, int stallId, int staffId, int vendorId, StallModel stall, StaffModel staff, VendorModel vendor)
        {
            this.contractID = contractID;
            this.fileUrl = fileUrl;
            this.code = code;
            this.status = status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.stallId = stallId;
            this.staffId = staffId;
            this.vendorId = vendorId;
            //this.stall = stall;
            //this.staff = staff;
            //this.vendor = vendor;
        }

    }
}
