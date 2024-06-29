using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    internal class PaymentReferenceModel
    {
        private int paymentReferenceID;
        private string imageURL;
        private string fileName;
        private int paymentID;
        // properties

        public int PaymentReferenceID { 
            get => paymentReferenceID;
            set => paymentReferenceID = value;
        }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public string FileName { get => fileName; set => fileName = value; }    
        public int PaymentID { get => paymentID; set => paymentID = value; }
        public PaymentReferenceModel() { }
        public PaymentReferenceModel(int id, string image, string fileName, int paymentID) { 
            this.paymentReferenceID = id;
            this.imageURL = image;
            this.fileName = fileName;
            this.paymentID = paymentID;
        }
    }
}
