using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    public interface IStaffRepository
    {
        void Add(StaffModel staffModel);
        void Edit(StaffModel staffModel);
        void Delete(StaffModel staffModel);
        IEnumerable<StaffModel> GetAll();
        IEnumerable<StaffModel> GetByValue(string value); // Search
    }
}
