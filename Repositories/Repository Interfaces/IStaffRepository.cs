using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    public interface IStaffRepository
    {
        void InsertOrUpdate(StaffModel staffModel, int primaryKey, bool isPasswordChanged);
        void Delete(StaffModel staffModel);
        IEnumerable<StaffModel> GetAll();
        IEnumerable<StaffModel> GetByValue(string value); // Search
    }
}
