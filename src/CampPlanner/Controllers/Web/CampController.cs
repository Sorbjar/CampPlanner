using CampPlanner.Models.Database.Repository;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using CampPlanner.Models;
using System.Threading.Tasks;
using AutoMapper;
using CampPlanner.ViewModels.Camp;
using System.Collections.Generic;

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
            CampPlannerUser user = await _userManager.FindByNameAsync(User.GetUserName());

            var camps = Mapper.Map<IEnumerable<CampViewModel>>(_repository.GetAllCamps(user));

            return View(camps);
        }

        // GET: /Camp/Manage
        [HttpGet]
        public async Task<IActionResult> Manage(int id)
        {
            CampPlannerUser user = await _userManager.FindByNameAsync(User.GetUserName());

            var camp = _repository.GetCamp(id);

            //TODO correct authorisation
            if (camp.CanAccess(user))
            {
                return View(Mapper.Map<CampViewModel>(camp));
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
