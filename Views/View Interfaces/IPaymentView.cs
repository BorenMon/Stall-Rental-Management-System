using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    internal interface IPaymentView
    {

        int PaymentID
        {
            get;
            set;
        }

        string PaymentMethod
        {
            get;
            set;
        }

        DateTime PaymentDate
        {
            get;
            set;
        }

        string Status
        {
            get;
            set;
        }

        string Currency
        {
            get;
            set;
        }

        decimal Amount
        {
            get;
            set;
        }

        int InvoiceID
        {
            get;
            set;
        }
        string ReferenceImgeUrl { get; set; }
        string ReferenceFileName { get; set; }
        event EventHandler SavePayment;
        event EventHandler SearchPayment;
        event EventHandler UpdatePayment;
        event EventHandler DeletePayment;

        void setPaymentBinding(BindingSource bindingSource);
        void setPaymentReferenceBinding(BindingSource bindingSource);
        void setInvoiceID(IEnumerable<int> ids);
    }

}
