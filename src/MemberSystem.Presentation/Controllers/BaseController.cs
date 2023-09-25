using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MemberSystem.Web.Controllers
{
    [Authorize(Roles = "Member")]
    public class BaseController : Controller
    {
    }
}
