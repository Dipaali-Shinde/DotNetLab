using CollegeDemo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        [HttpGet]
        public IActionResult EmpIndex()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EmpLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EmpLogin(EmployeeLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Username == "dipali" && model.Password == "dip@123")
            {
                return RedirectToAction("EmpIndex", "Employee");
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }

        public async Task<IActionResult> EmpSignup()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("MainIndex", "Main");
        }
       
        
    }
}
