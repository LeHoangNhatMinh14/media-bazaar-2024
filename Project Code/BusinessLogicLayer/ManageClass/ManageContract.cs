using BusinessLogicLayer.Class;
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
        private List<Contracts> contracts;

        public ManageContract() 
        {
            contracts = new List<Contracts>();
        }


        public void AddContract(Contracts contract)
        {
            // add to the database

            contracts.Add(contract);
        }

        public void TerminateContract(Contracts contract, string reason ) 
        {
            // terminateContract in the database
        }

        public Contracts GetContract(Employee employee)
        {
            //get Contract from database
            
            return null;
        }
        public List<Contracts> GetContractList()
        {
            // get all contract in the database
            return contracts;
        }


    }
}
