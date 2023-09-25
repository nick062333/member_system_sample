using MemberSystem.Application.Queries;
using MemberSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MemberSystem.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IOrgService _orgService;

        public UserController(IOrgService orgService) 
        {
            _orgService = orgService;
        }

        // GET: UserController
        public async Task<ActionResult> Register()
        {
            ViewBag.OrgList = (await _orgService.GetAllOrgListAsync())
                .Select(x => new SelectListItem(x.Title, x.Id.ToString()))
                .ToList();

            return View() ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRegisterModel userRegisterDto)
        {
            if (!ModelState.IsValid)
                return View(userRegisterDto);

            return RedirectToAction("Account", "Index");
        }
    }
}
