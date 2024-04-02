using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaar_WebApp.Pages
{
    public class ScheduleModel : PageModel
    {
		ManageShifts mS = ManageShiftFactory.Create();
		ManageDepartment mD = ManageDepartmentFactory.Create();
		public bool IsPageOpen { get; set; }
		public Employee employee { get; set; }
		public List<Shift> employeeShifts { get; set; }
		public ActionResult OnGet()
		{
			if (HttpContext.Session.GetString("EmployeeID") == null)
			{
				return RedirectToPage("/Index");
			}
			int id = (int)HttpContext.Session.GetInt32("EmployeeID");
			employeeShifts = mS.GetShiftsOfEmployee(id);
			return Page();
		}

		public string DepName(int depID)
		{ 
			string name = mD.GetDepartmentName(depID);
			return name;
		}
	}
}
