using BusinessLogicLayer.ManageClass;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
