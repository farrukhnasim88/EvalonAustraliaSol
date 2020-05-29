using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalonAustralia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvalonAustralia.Areas.Staff.Controllers
{
    public class HomeController : StaffAreaController
    {

        public HomeController(UserManager<IdentityUser> userManager, ApplicationDbContext context) : base(userManager, context)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
