using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Factory;

namespace MediaBazaar_WebApp.Pages
{
    public class IndexModel : PageModel
    {
		ManageEmployee mE = ManageEmployeeFactory.Create();
        public bool IsPageOpen { get; set; }
        [BindProperty]
        public Employee Employee { get; set; }

        public void OnGet()
		{ 
            IsPageOpen = true;
        }

        public ActionResult OnPost(string handler)
        {
            if (!ModelState.IsValid)
			{
				return RedirectToPage();
			}
			else
			{
				handler = "Login";
				var employee = mE.GetEmployee(Employee.email , Employee.password);
					if (employee != null)
					{
						var claims = new List<Claim>
						{
						new Claim(ClaimTypes.Name, employee.EmployeeInfo),
						new Claim(ClaimTypes.Email, employee.email),
						};

						var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


						HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

						HttpContext.Session.SetString("Name", employee.firstName+" "+employee.lastName);
						HttpContext.Session.SetString("Email", employee.email) ;
						HttpContext.Session.SetInt32("EmployeeID", employee.employeeID);
						return RedirectToPage("/Schedule");
					}
					else
					{
						return RedirectToPage();
					}				
			}
		}


    }
}
