﻿using System;
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
        public DateTime shiftDate { get; set; }
        public int FK_DepartmentID { get; set; }
        public string EmployeeEmail { get; set; }
        public string ShiftInfo => $"{shiftDate.Date.ToString("MM/dd/yyyy")}, {shiftType}, {peopleNeeded}";
        public string ShiftInfoAssigned => $"{shiftDate.Date.ToString("MM/dd/yyyy")}, {shiftType}";

        public Shift(int shiftid, string shiftType, int peopleNeeded, DateTime shiftDate, int fK_DepartmentID)
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
            this.shiftid = shiftid;
            this.shiftType = shiftType;
            this.peopleNeeded = peopleNeeded;
            this.shiftDate = shiftDate;
            this.FK_DepartmentID = FK_DepartmentID;
        }
    }
}
