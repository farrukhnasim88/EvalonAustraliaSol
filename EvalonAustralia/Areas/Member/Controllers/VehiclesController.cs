using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalonAustralia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvalonAustralia.Areas.Member.Controllers
{
    public class VehiclesController : MemberAreaController
    {


         

        public VehiclesController(UserManager<IdentityUser> userManager, ApplicationDbContext context) : base(userManager, context)
        {

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
