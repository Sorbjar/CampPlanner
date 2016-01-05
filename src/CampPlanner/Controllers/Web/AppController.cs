using Microsoft.AspNet.Mvc;

namespace CampPlanner.Controllers.Web
{
    public class AppController : Controller
    {
        public AppController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
