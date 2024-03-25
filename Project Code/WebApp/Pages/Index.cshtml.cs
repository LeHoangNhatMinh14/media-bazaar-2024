using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaar_WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public bool IsPageOpen { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            IsPageOpen = true;
        }

        public ActionResult OnPost(string handler)
        {
            handler = "Login";
            IsPageOpen = false;
            return RedirectToPage("/Schedule");
            
        }
    }
}
