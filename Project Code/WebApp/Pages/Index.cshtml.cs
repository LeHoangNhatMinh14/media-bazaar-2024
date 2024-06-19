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
			if (ModelState.IsValid)
			{
				return RedirectToPage();
			}
			else
			{
				handler = "Login";
				Employee = mE.GetEmployee(Employee.email, Employee.password);
				if (Employee != null)
				{
					if (Employee.firstLogin == false)
					{
						var claims = new List<Claim>
						{
						new Claim(ClaimTypes.Name, Employee.EmployeeInfo),
						new Claim(ClaimTypes.Email, Employee.email),
						};

						var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

						HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

						HttpContext.Session.SetString("Name", Employee.firstName + " " + Employee.lastName);
						HttpContext.Session.SetString("Email", Employee.email);
						HttpContext.Session.SetInt32("EmployeeID", Employee.employeeID);
						return RedirectToPage("/PersonalData");
					}
					else 
					{ 
						return RedirectToPage("/FirstLogin", new { id = Employee.employeeID });
					}
				}
				else { return RedirectToPage(); }
			}

		}
    }
}
