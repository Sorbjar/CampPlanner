using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
