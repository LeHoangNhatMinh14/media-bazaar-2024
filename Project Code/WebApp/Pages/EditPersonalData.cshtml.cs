using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaar_WebApp.Pages
{
    public class EditPersonalDataModel : PageModel
    {
		public bool IsPageOpen { get; set; }
        [BindProperty]
        public Employee employee { get; set; }
        [BindProperty]
        public Employee editedEmp { get; set; } 

        private ManageEmployee me = ManageEmployeeFactory.Create();
		public void OnGet()
        {
			IsPageOpen = false;
            int id = Convert.ToInt32(HttpContext.Session.GetString("EmployeeID"));
            employee = me.GetEmployeeByID(id);
		}
    }
}
