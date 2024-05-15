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
        ManageAvailability mA = ManageAvailabilityFactory.Create();
        public bool IsPageOpen { get; set; }
        public Employee employee { get; set; }
        public Contract contract { get; set; }
        [BindProperty]
        public bool Monday {  get; set; }
		[BindProperty]
		public bool Tuesday {  get; set; }
		[BindProperty]
		public bool Wednesday {  get; set; }
		[BindProperty]
		public bool Thursday {  get; set; }
		[BindProperty]
		public bool Friday {  get; set; }
		[BindProperty]
		public bool Saturday {  get; set; }
		[BindProperty]
		public bool Sunday {  get; set; }

        public ActionResult OnGet()
        {
            if (HttpContext.Session.GetString("EmployeeID") == null)
            {
                return RedirectToPage("/Index");
            }
            int id = (int)HttpContext.Session.GetInt32("EmployeeID");
            employee = mE.GetEmployeeByID(id);
            contract = mC.GetContract(id);
            if (mA.GetAvailability(id) != null)
            {
                Availability displayAvailability = mA.GetAvailability(id);
                Monday = displayAvailability.monday;
                Tuesday = displayAvailability.tuesday;
                Wednesday = displayAvailability.wednesday;
                Thursday = displayAvailability.thursday;
                Friday = displayAvailability.friday;
                Saturday = displayAvailability.saturday;
                Sunday = displayAvailability.sunday;
			}

			return Page();
		}


        public ActionResult OnPost() 
        {
            Availability availability = new Availability((int)HttpContext.Session.GetInt32("EmployeeID"),Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday);
            mA.AddAvailability(availability);
            return RedirectToPage();
        }
    }
}
