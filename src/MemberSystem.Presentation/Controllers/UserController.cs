using MemberSystem.Web.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MemberSystem.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRegisterDto userRegisterDto)
        {
            if (!ModelState.IsValid)
                return View(userRegisterDto);

            return RedirectToAction("Account", "Index");
        }
    }
}
