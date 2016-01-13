using Microsoft.AspNet.Mvc;

namespace CampPlanner.Controllers.Web
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
