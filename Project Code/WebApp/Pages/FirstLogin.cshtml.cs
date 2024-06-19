using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaar_WebApp.Pages
{
    public class FirstLoginModel : PageModel
    {
		ManageEmployee mE = ManageEmployeeFactory.Create();
        private Employee newEmployee;
		public bool IsPageOpen { get; set; }

		public void OnGet(int id)
        {
            newEmployee = mE.GetEmployeeByID(id);

        }
    }
}
