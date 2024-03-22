using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IShifts
    {
        Shift GetShiftbyID(int ID);
        void DeleteShifts(int ID);
        void AddShifts(Shift shift);
    }
}
