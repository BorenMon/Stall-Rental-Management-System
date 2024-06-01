using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    internal class StallModel
    {
        // field
        private int stallID;
        private string code;
        private string status;
        private string type;
        private float size;
        private decimal monthlyFee;
        private string location;

        // Properties
        public int Id
        {
            get { return stallID; }
            set { stallID = value; }
        }

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

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public float Size
        {
            get { return size; }
            set { size = value; }
        }

        public decimal MonthlyFee
        {
            get { return monthlyFee; }
            set { monthlyFee = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        // Constructors
        public StallModel() { }

        public StallModel(int id, string code, string status, string type, float size, decimal monthlyFee, string location)
        {
            this.stallID = id;
            this.code = code;
            this.status = status;
            this.type = type;
            this.size = size;
            this.monthlyFee = monthlyFee;
            this.location = location;
        }

    }
}
