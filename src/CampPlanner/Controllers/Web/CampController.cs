using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace CampPlanner.Controllers.Web
{
    [Authorize]
    public class CampController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
