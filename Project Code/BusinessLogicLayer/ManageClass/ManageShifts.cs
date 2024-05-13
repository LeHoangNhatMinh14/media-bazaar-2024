using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using System.Collections.Generic;

namespace BusinessLogicLayer.ManageClass
{
    public class ManageShifts
    {
        private readonly IShifts _IShifts;

        public ManageShifts(IShifts IShifts)
        {
            _IShifts = IShifts;
        }

        public void AddShift(Shift shift)
        {
            _IShifts.AddShifts(shift);
        }

        public void AssignShift(int shiftID, int employeeID)
        {
            _IShifts.AssignShift(shiftID, employeeID);
        }

        public void DeleteShift(int ID)
        {
            _IShifts.DeleteShifts(ID);
        }

        public Shift GetShiftByID(int ID)
        {
            return _IShifts.GetShiftbyID(ID);
        }

        public List<Shift> GetShiftsOfEmployee(int employeeID)
        {
            return _IShifts.GetShiftsofEmployee(employeeID);
        }

        public List<Shift> GetUnassignedShifts()
        {
            return _IShifts.GetUnassignedShifts();
        }

        public List<Shift> GetWeeklyShifts(int employeeID ,List<DateTime> week)
        { 
            return _IShifts.GetShiftByWeek(employeeID,week);
        }

        public List<Shift> GetShiftsbyperiod(DateTime start, DateTime end, string department)
        {
            return _IShifts.GetShiftsinPeriod(start, end, department);
        }

        public void CreateShiftinPeriod(DateTime start, DateTime end, int departmentID, int peopleNeeded)
        {
            _IShifts.CreateShiftinPeriod(start, end, departmentID,peopleNeeded);
        }

        public bool isEmployeeOnShift(int shiftID, int employeeID)
        {
            return _IShifts.isEmployeeOnShift(shiftID, employeeID);
        }

        public bool CanAssignShift(int employeeID, Shift assignedShift)
        {
            if (assignedShift.shiftType == "Morning")
            {
                assignedShift.shiftDate = assignedShift.shiftDate.AddDays(-1);
            }
            List<Shift> shiftsOfDate = _IShifts.GetShiftsofDateofEmployee(employeeID, assignedShift.shiftDate);
            if (shiftsOfDate.Count > 0)
            {
                string shiftType = assignedShift.shiftType;
                DateTime nextDayShift = assignedShift.shiftDate.AddDays(1);
                foreach (Shift shift in shiftsOfDate)
                {
                    if ((shift.shiftType == "Morning" && shiftType == "Evening") ||
                        (shift.shiftType == "Evening" && shiftType == "Night") ||
                        (shift.shiftType == "Night" && shiftType == "Morning" && shift.shiftDate == nextDayShift))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }



    }
}
