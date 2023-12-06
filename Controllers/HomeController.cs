using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Dilara";
            ViewBag.Surname = "Huseynova";
            ViewBag.Age = 30;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "1234567890";
            return View();
        }

    }
}
