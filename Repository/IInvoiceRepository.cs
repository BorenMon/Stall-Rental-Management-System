using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories
{
    public interface IInvoiceRepository
    {
        IEnumerable<InvoiceModel> GetAll();
        void Add(InvoiceModel invoice);
        void Update(InvoiceModel invoice);
        void Delete(int invoiceID);
        bool ContractIDExists(string contractID);
    }
}