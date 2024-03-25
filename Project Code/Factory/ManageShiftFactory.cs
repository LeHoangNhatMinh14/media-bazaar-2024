using BusinessLogicLayer.ManageClass;
using DAL;

namespace Factory
{
    public static class ManageShiftFactory
    {
        public static ManageShifts manageShifts;
        public static ManageShifts Create()
        {
            if (manageShifts == default)
            {
                manageShifts = new(new ShiftRepo());
            }
            return manageShifts;
        }
    }
}
