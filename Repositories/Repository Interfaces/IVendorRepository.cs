using Stall_Rental_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    internal interface IVendorRepository
    {
        void Add(VendorModel vendorModel);
        void Delete(int id);
        void Update(VendorModel vendorModel);
        IEnumerable<VendorModel> GetAll();
        IEnumerable<VendorModel> GetByID(int id);
        //
    }
}
