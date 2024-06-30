using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    public interface IInvoiceRepository
    {
        void InsertOrUpdate(InvoiceModel invoiceModel);
        IEnumerable<InvoiceModel> GetAll();
        IEnumerable<InvoiceModel> GetByValue(string value); // Search
    }
}