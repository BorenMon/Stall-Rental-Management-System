using System.Collections.Generic;

namespace Stall_Rental_Management_System.Models
{
    public interface IStaffRepository
    {
        void Add(StaffModel staffModel);
        void Edit(StaffModel staffModel);
        void Delete(StaffModel staffModel);
        IEnumerable<StaffModel> GetAll();
        IEnumerable<StaffModel> GetByValue(); // Search
    }
}
