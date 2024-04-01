using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IContractsDAL
    {
        void AddContract(Contract contract);
        Contract GetContract(int employeeID);



    }
}
