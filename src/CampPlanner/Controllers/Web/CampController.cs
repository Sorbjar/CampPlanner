using CampPlanner.Models.Database.Repository;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using CampPlanner.Models;
using System.Threading.Tasks;

namespace CampPlanner.Controllers.Web
{
    [Authorize]
    public class CampController : Controller
    {
        private ICampPlannerRepository _repository;
        private UserManager<CampPlannerUser> _userManager;

        public CampController(ICampPlannerRepository repository, UserManager<CampPlannerUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        // GET: /Camp/Index
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CampPlannerUser user = await _userManager.FindByIdAsync(User.GetUserId());

            var camps = _repository.GetAllCamps(user);

            return View(camps);
        }
    }
}
