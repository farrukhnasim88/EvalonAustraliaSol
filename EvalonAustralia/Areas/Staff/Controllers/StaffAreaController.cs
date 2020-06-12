using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalonAustralia.Data;
using EvalonAustralia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog;

namespace EvalonAustralia.Areas.Staff.Controllers
{
    [Area("Staff")]
    [Authorize(Roles = "Staff")]
    public class StaffAreaController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        protected readonly ApplicationDbContext _context;
        private Logger _logger = LogManager.GetCurrentClassLogger();



        public StaffAreaController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {



            try
            {
                _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        protected async Task<IdentityUser> GetIdentityUserAsync()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            return user;
        }

        protected async Task<Person> GetMemberAsync()
        {
            var user = await GetIdentityUserAsync();
            var person = await _context.People.FirstOrDefaultAsync(p => p.PersonId.Equals(user.Id));
            return person;
        }







    }

}
