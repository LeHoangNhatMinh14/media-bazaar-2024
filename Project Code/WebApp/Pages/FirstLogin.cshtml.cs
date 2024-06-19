using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using Factory;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MediaBazaar_WebApp.Pages
{
    public class FirstLoginModel : PageModel
    {
		ManageEmployee mE = ManageEmployeeFactory.Create();
        private static Employee newEmployee;
        [BindProperty]
        public string newPassword {  get; set; }
		public bool IsPageOpen { get; set; }

		public void OnGet(int id)
        {
            IsPageOpen = true;
            newEmployee = mE.GetEmployeeByID(id);
        }

        public IActionResult OnPost()
        {
            if(string.IsNullOrWhiteSpace(newPassword))
            {
                var claims = new List<Claim>
                        {
                        new Claim(ClaimTypes.Name, newEmployee.EmployeeInfo),
                        new Claim(ClaimTypes.Email, newEmployee.email),
                        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

                HttpContext.Session.SetString("Name", newEmployee.firstName + " " + newEmployee.lastName);
                HttpContext.Session.SetString("Email", newEmployee.email);
                HttpContext.Session.SetInt32("EmployeeID", newEmployee.employeeID);
                return RedirectToPage("/PersonalData");
            }
            else
            {
                newEmployee.password = newPassword;
                mE.EditEmployee(newEmployee);
                var claims = new List<Claim>
                        {
                        new Claim(ClaimTypes.Name, newEmployee.EmployeeInfo),
                        new Claim(ClaimTypes.Email, newEmployee.email),
                        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

                HttpContext.Session.SetString("Name", newEmployee.firstName + " " + newEmployee.lastName);
                HttpContext.Session.SetString("Email", newEmployee.email);
                HttpContext.Session.SetInt32("EmployeeID", newEmployee.employeeID);
                return RedirectToPage("/PersonalData");
            }
        }
    }
}
