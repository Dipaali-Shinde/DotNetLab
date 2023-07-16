using Microsoft.AspNetCore.Mvc;

namespace CollegeDemo.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
