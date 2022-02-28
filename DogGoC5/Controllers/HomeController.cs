using Microsoft.AspNetCore.Mvc;

namespace DogGoC5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
