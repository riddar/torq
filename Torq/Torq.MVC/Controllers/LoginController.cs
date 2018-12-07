using System.Web.Mvc;
using Torq.Models.Objects;
using Torq.MVC.EmployeesService;

namespace Torq.MVC.Controllers
{
	public class LoginController : Controller
    {

        public ActionResult LoginPage()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Autherize(Employee employee)
		{
			using (var employeeService = new EmployeeServiceClient())
			{
				var user = employeeService.GetEmployeeByUserName(employee.UserName);
				if (user == null || user?.Password != employee.Password)
				{
					employee.LoginError = "Wrong username or password";
					return View(nameof(LoginPage), employee);
				}
					
			}

			return RedirectToAction("Index", "Home", employee);
		}
    }
}