using Microsoft.AspNetCore.Mvc;

namespace CollegeDemo.Controllers
{
    public class MainController : Controller
    {
        public IActionResult MainIndex()
        {
            return View();
        }
    }
}
