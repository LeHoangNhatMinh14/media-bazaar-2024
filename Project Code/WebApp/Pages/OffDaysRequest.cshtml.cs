using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MediaBazaar_WebApp.Pages
{
    public class OffDaysRequestModel : PageModel
    {
		public bool IsPageOpen { get; set; }
		[BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
		public DateTime DateTime { get; set; }
		public void OnGet()
		{
			IsPageOpen = false;
		}
	}
}
