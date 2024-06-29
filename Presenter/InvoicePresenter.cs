using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Views;

namespace Stall_Rental_Management_System.Presenters
{
    public class InvoicePresenter
    {
        private readonly IInvoiceView view;
        private readonly IInvoiceRepository repository;

        public InvoicePresenter(IInvoiceView view, IInvoiceRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }

        public void LoadInvoices()
        {
            var invoices = repository.GetAll();
            view.DisplayInvoices(invoices);
        }

        public void AddInvoice(InvoiceModel invoice)
        {
            repository.Add(invoice);
            view.ShowMessage("Record Inserted Successfully");
            LoadInvoices();
        }

        public void UpdateInvoice(InvoiceModel invoice)
        {
            repository.Update(invoice);
            view.ShowMessage("Record Updated Successfully");
            LoadInvoices();
        }

        public void DeleteInvoice(int invoiceID)
        {
            repository.Delete(invoiceID);
            view.ShowMessage("Record Deleted Successfully");
            LoadInvoices();
        }
    }
}
