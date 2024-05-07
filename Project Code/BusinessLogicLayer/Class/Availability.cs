using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public class Availability
    {
        public int   employeeID {  get; set; }
        public int?  weekNrm { get; set; }
        public bool  monday { get; set; }
        public bool  tuesday { get; set; }
        public bool  wednesday { get; set; }
        public bool  thursday { get; set; }
        public bool  friday { get; set; }
        public bool  saturday { get; set; }
        public bool  sunday { get; set; }
        public bool? accepted { get; set; }

        public Availability()
        {
        }

		public Availability(int employeeID, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, bool sunday)
		{
			this.employeeID = employeeID;
			this.monday = monday;
			this.tuesday = tuesday;
			this.wednesday = wednesday;
			this.thursday = thursday;
			this.friday = friday;
			this.saturday = saturday;
			this.sunday = sunday;
		}

		public Availability(int employeeID, int? weekNrm, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, bool sunday, bool? accepted)
        {
            this.employeeID = employeeID;
            this.weekNrm = weekNrm;
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
            this.friday = friday;
            this.saturday = saturday;
            this.sunday = sunday;
            this.accepted = accepted;
        }
    }
}
