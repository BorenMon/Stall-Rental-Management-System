using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    internal class ContractModel
    {
        //Fields
        private int id;
        private string fileUrl;
        private string contractCode;
        private string status;
        private DateTime startDate ;
        private DateTime endDate;
        // relationship 
        private int stallId;
        //
        private int vendorId;
        //
        private int staffId;
        //
    }
}
