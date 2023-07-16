using CollegeDemo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CollegeDemo.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult StudIndex()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudLogin(StudentLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Username == "dipali" && model.Password == "dip@123")
            { 
                return RedirectToAction("StudIndex", "Student");
            }

            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }

        public async Task<IActionResult> StudSignup()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("MainIndex", "Main");
        }
      
    }
}
