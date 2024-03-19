using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public class Shift
    {
        public int shiftid {  get; set; }
        public string shiftType { get; set; }
        public int peopleNeeded { get; set; }
        public DateOnly shiftDate { get; set; }
        public int FK_DepartmentID { get; set; }

        public Shift(int shiftid, string shiftType, int peopleNeeded, DateOnly shiftDate, int fK_DepartmentID)
        {
            this.shiftid = shiftid;
            this.shiftType = shiftType;
            this.peopleNeeded = peopleNeeded;
            this.shiftDate = shiftDate;
            FK_DepartmentID = fK_DepartmentID;
        }


        //Constructer For Mapper
        public Shift(int shiftid)
        {
            this.shiftType = shiftType;
            this.peopleNeeded = peopleNeeded;
            this.shiftDate = shiftDate;
            this.FK_DepartmentID = FK_DepartmentID;
        }
    }
}
