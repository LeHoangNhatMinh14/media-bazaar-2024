using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediaBazaar_WebApp.Pages
{
    public class ScheduleModel : PageModel
    {
		ManageShifts mS = ManageShiftFactory.Create();
		ManageDepartment mD = ManageDepartmentFactory.Create();
		public bool IsPageOpen { get; set; }
		public Employee employee { get; set; }
		public List<Shift> employeeShifts { get; set; }
		public List<DateTime> weeks { get; set; }
		public string Date {  get; set; }
        private int _x {get; set; }


        public ActionResult OnGet(string handler)
		{
			if (HttpContext.Session.GetString("EmployeeID") == null)
			{
				return RedirectToPage("/Index");
			}

            int id = (int)HttpContext.Session.GetInt32("EmployeeID");

            _x = HttpContext.Session.GetInt32("_x") ?? 0;
            GetWeek();
            switch (handler)
            {
                case "Previous":
                    GetWeek(-7);
                    break;
                case "Next":
                    GetWeek(7);
                    break;
                case "DaysOff":
                    return RedirectToPage("/OffDaysRequest");
            }

            employeeShifts = mS.GetWeeklyShifts(id, weeks);

            HttpContext.Session.SetInt32("_x", _x);

            return Page();
        }

		public string DepName(int depID)
		{ 
			string name = mD.GetDepartmentName(depID);
			return name;
		}

		private void GetWeek(int x)
		{
            _x += x;
			weeks = new List<DateTime>();

            DateTime baseDate = DateTime.Today.AddDays(_x);

            var baseStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);

            for (int i = 0; i < 7; i++)
            {
                weeks.Add(baseStart.AddDays(i));
            }

            var thisWeekStart = baseStart;
            var thisWeekEnd = baseStart.AddDays(6);

            Date = $"Day {thisWeekStart.Day}/{thisWeekStart.Month} - {thisWeekEnd.Day}/{thisWeekEnd.Month} , {baseDate.Year}";
        }
        
        private void GetWeek()
		{
			weeks = new List<DateTime>();

            DateTime baseDate = DateTime.Today.AddDays(0);

            var baseStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);

            for (int i = 0; i < 7; i++)
            {
                weeks.Add(baseStart.AddDays(i));
            }

            var thisWeekStart = baseStart;
            var thisWeekEnd = baseStart.AddDays(6);

            Date = $"Day {thisWeekStart.Day}/{thisWeekStart.Month} - {thisWeekEnd.Day}/{thisWeekEnd.Month} , {baseDate.Year}";
        }
	}
}
