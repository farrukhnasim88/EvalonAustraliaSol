using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalonAustralia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvalonAustralia.Areas.Management.Controllers
{
    public class HomeController : ManagementAreaController
    {

        public HomeController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
            : base(userManager, context)
        {
        }


        public IActionResult index()
        {
            return View();
        }
    }
}
