using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaar_WebApp.Pages
{
    public class EditPersonalDataModel : PageModel
    {
		public bool IsPageOpen { get; set; }
		public void OnGet()
        {
			IsPageOpen = false;
		}
    }
}
