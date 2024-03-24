using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IShifts
    {
        Shift GetShiftbyID(int ID);
        void DeleteShifts(int ID);
        void AddShifts(Shift shift);
        void AssignShift(int shiftID, int employeeID);
        List<Shift> GetShiftsofEmployee(int employeeID);
        Shift GetLatestShiftForEmployee(int employeeID);
    }
}
