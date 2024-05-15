using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IAvailabilityDAL
    {
        void AddUsualAvailability(Availability availability);
        void RequestAvailabilityChange(Availability availability);

        Availability GetAvailability(int id);
        List<Availability> GetChangeRequests();
        Availability GetAvailabilitiesofEmployee(int employeeID);
    }
}
