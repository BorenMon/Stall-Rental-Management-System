using System.Collections.Generic;
using Stall_Rental_Management_System.Models;

namespace Stall_Rental_Management_System.Repositories.Repository_Interfaces
{
    internal interface IContractRepository
    {
        void Add(ContractModel contractModel);
        void Update(ContractModel contractModel);
        IEnumerable<ContractModel> GetAll();
        IEnumerable<ContractModel> GetByID(string id);
        //
        IEnumerable<int> GetAllVendorID();
        IEnumerable<int> GetAllStallID();
    }
}
