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
		public ActionResult OnGet(string handler)
		{
			if (HttpContext.Session.GetString("EmployeeID") == null)
			{
				return RedirectToPage("/Index");
			}
			int id = (int)HttpContext.Session.GetInt32("EmployeeID");
			GetWeek(0);
			employeeShifts = mS.GetWeeklyShifts(id,weeks);
			switch (handler)
			{
				case "Previous":
					GetWeek(7);
					employeeShifts.Clear();
					employeeShifts = mS.GetWeeklyShifts(id, weeks);
					return Page();
				case "Next":
					GetWeek(-7);
					employeeShifts.Clear();
					employeeShifts = mS.GetWeeklyShifts(id, weeks);
					return Page();
				case "DaysOff":
					return RedirectToPage("/OffDaysRequest");
			}
			return Page();
		}

		public string DepName(int depID)
		{ 
			string name = mD.GetDepartmentName(depID);
			return name;
		}

		public void GetWeek(int x)
		{
			weeks = new List<DateTime>();

			DateTime baseDate = DateTime.Today;
			var thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek - x);
			var thisWeekEnd = baseDate.AddDays(7).AddMinutes(-1);

			for	(int i = 0; i <7; i++) 
			{
				weeks.Add(thisWeekStart.AddDays(i));
			}

			Date = $"Day {thisWeekStart.Day}/{thisWeekStart.Month} - {thisWeekEnd.Day}/{thisWeekEnd.Month} , {thisWeekStart.Year}";

		}
	}
}
