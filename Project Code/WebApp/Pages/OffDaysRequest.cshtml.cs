using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MediaBazaar_WebApp.Pages
{
    public class OffDaysRequestModel : PageModel
    {
		public ManageDaysOff mdo = ManageDaysOffFactory.Create();
		public bool IsPageOpen { get; set; }
		[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime StartDate { get; set; }
		[BindProperty]
		public int DaysOff { get; set; }
		[BindProperty]
		public string? Reason { get; set; }
		[BindProperty]
		public string start {  get; set; }

		public void OnGet()
		{
			IsPageOpen = false;
			StartDate = DateTime.Now.AddDays(7);
			start = StartDate.ToString("yyyy-MM-dd");
			
		}
		public ActionResult OnPost(string handler)
		{
			if (HttpContext.Session.GetString("EmployeeID") == null)
			{
				return RedirectToPage("/Index");
			}
			int id = (int)HttpContext.Session.GetInt32("EmployeeID");

			if (handler == "Request")
			{
				Reason = Reason.ToString();
				DateTime endDate = StartDate.AddDays(DaysOff - 1);
				RequestDaysOff requestDaysOff = new RequestDaysOff(id,Reason, StartDate, endDate, false);
				mdo.AddDaysOffRequest(requestDaysOff);
				return RedirectToPage("/Schedule");
			}
			return Page();
		}
	}
}
