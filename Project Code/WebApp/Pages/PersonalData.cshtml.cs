using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaar_WebApp.Pages
{
    public class PersonalDataModel : PageModel
    {
        ManageEmployee mE = ManageEmployeeFactory.Create();
        ManageContract mC = ManageContractFactory.Create();
        public bool IsPageOpen { get; set; }
        public Employee employee { get; set; }
        public Contract contract { get; set; } 

		public ActionResult OnGet()
        {
            if (HttpContext.Session.GetString("EmployeeID") == null)
            {
                return RedirectToPage("/Index");
            }
            int id = (int)HttpContext.Session.GetInt32("EmployeeID");
            employee = mE.GetEmployeeByID(id);
            contract = mC.GetContract(id);
			return Page();
		}
    }
}
