using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Example.Controllers
{
    public class RoleContoller : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleContoller(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
