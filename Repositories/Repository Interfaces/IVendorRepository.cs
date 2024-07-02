using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    public interface IVendorRepository
    {
        void InsertOrUpdate(VendorModel vendorModel, int primaryKey, bool isPasswordChanged);
        void Delete(VendorModel vendorModel);
        IEnumerable<VendorModel> GetAll();
        IEnumerable<VendorModel> GetByValue(string value); // Search
    }
}