using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/PostUser")]
        public IActionResult PostUser()
        {
            return View();
        }
    }
}
