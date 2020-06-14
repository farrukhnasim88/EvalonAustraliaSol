using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalonAustralia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvalonAustralia.Areas.Member.Controllers
{
    public class HomeController : MemberAreaController
    {

        private readonly VehiclesService _vehicles;
        public HomeController(UserManager<IdentityUser> userManager, ApplicationDbContext context, VehiclesService vehicles) : base(userManager, context)
        {
            _vehicles = vehicles;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListVehicles()
        {
            var findAllVehicles = _vehicles.GetAllVehicles();
            return View(findAllVehicles);
        }



    }
}
