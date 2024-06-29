using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stall_Rental_Management_System.Models;
namespace Stall_Rental_Management_System.Views
{
    public interface IInvoiceView
    {
        void DisplayInvoices(IEnumerable<InvoiceModel> invoices);
        void ShowMessage(string message);
    }
}
