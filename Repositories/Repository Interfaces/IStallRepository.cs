using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    public interface IStallRepository
    {
        void InsertOrUpdate(StallModel staffModel, int primaryKey);
        void Delete(StallModel staffModel);
        IEnumerable<StallModel> GetAll();
        IEnumerable<StallModel> GetByCode(string code);
    }
}