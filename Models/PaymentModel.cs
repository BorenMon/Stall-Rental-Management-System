using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    internal class PaymentModel
    {
        // Fields (private by default)
        private int paymentID;
        private string paymentMethod;
        private DateTime paymentDate;
        private string status;
        private string currency;
        private decimal amount;
        private int invoiceID;

        // Properties (public access with validation)
        public int PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        // Default Constructor (no arguments)
        public PaymentModel(){}

        // Parameterized Constructor (accepts values for all fields)
        public PaymentModel(int paymentID, string paymentMethod, DateTime paymentDate, string status, string currency, decimal amount, int invoiceID)
        {
            this.paymentID = paymentID;
            this.paymentMethod = paymentMethod;
            this.paymentDate = paymentDate;
            this.status = status;
            this.currency = currency;
            this.amount = amount;
            this.invoiceID = invoiceID;
        }
    }

}
