using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
    public class ManageContract
    {
        private List<Class.Contract> contracts;

        public ManageContract() 
        {
            contracts = new List<Class.Contract>();
        }


        public void AddContract(Class.Contract contract)
        {
            // add to the database

            contracts.Add(contract);
        }

        public void TerminateContract(Class.Contract contract, string reason ) 
        {
            // terminateContract in the database
        }

        public Class.Contract GetContract(Employee employee)
        {
            //get Contract from database
            
            return null;
        }
        public List<Class.Contract> GetContractList()
        {
            // get all contract in the database
            return contracts;
        }


    }
}
