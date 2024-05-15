using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MediaBazaar_WebApp.Pages
{
    public class AvailabilityRequestModel : PageModel
    {
		ManageAvailability mA = ManageAvailabilityFactory.Create();
		public bool IsPageOpen { get; set; }
		[BindProperty]
		public bool Monday { get; set; }
		[BindProperty]
		public bool Tuesday { get; set; }
		[BindProperty]
		public bool Wednesday { get; set; }
		[BindProperty]
		public bool Thursday { get; set; }
		[BindProperty]
		public bool Friday { get; set; }
		[BindProperty]
		public bool Saturday { get; set; }
		[BindProperty]
		public bool Sunday { get; set; }

		private static int _weekNmbr;
		public void OnGet(int weekNmbr)
		{
			_weekNmbr = weekNmbr;
		}

		public IActionResult OnPost()
		{
			Availability availability = new Availability((int)HttpContext.Session.GetInt32("EmployeeID"),_weekNmbr, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday,false);
			mA.RequestAvailabilityChange(availability);
			return RedirectToPage("/Schedule");
		}
	}
}
