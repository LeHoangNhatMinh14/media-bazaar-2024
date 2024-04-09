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
		[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
		public DateTime DateTime { get; set; }
		[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
		public DateTime DateToday { get; set; }
		[BindProperty]
		public string? Reason { get; set; }

		public void OnGet()
		{
			IsPageOpen = false;
			DateToday = DateTime.Now;
			DateTime = DateToday.AddDays(3);
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
				RequestDaysOff requestDaysOff = new RequestDaysOff(id,Reason, DateToday , DateTime, false);
				mdo.AddDaysOffRequest(requestDaysOff);
				return RedirectToPage("/Schedule");
			}
			return Page();
		}
	}
}
