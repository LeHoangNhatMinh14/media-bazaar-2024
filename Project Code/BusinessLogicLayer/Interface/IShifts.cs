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
        List<Shift> GetUnassignedShifts();
        List<Shift> GetShiftsofDateofEmployee(int employeeID, DateTime shiftDate);
        List<Shift> GetShiftByWeek(int employeeID, List<DateTime> weeks);
    }
}
