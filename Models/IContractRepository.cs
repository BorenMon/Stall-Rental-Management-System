using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
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
