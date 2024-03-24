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

        private Shift GetLastestshiftofEmployee(int employeeID)
        {
            return _IShifts.GetLatestShiftForEmployee(employeeID);
        }

        public bool CanAssignShift(int employeeID, int shiftID)
        {
            List<Shift> employeeShifts = GetShiftsOfEmployee(employeeID);

            if (employeeShifts.Count < 2)
            {
                return true;
            }

            Shift latestShift = employeeShifts[employeeShifts.Count - 1];
            Shift secondLatestShift = employeeShifts[employeeShifts.Count - 2];

            if (AreConsecutiveShifts(latestShift, secondLatestShift))
            {
                Shift newShift = _IShifts.GetShiftbyID(shiftID);

                if (!IsValidNextShift(latestShift, newShift))
                {
                    return false;
                }
            }

            return true;
        }
        private bool AreConsecutiveShifts(Shift shift1, Shift shift2)
        {
            return (shift1.shiftType == "Morning" && shift2.shiftType == "Evening")
                || (shift1.shiftType == "Evening" && shift2.shiftType == "Night");
        }

        private bool IsValidNextShift(Shift currentShift, Shift newShift)
        {
            return currentShift.shiftDate.AddDays(1) == newShift.shiftDate && newShift.shiftType == "Morning";
        }
    }
}
