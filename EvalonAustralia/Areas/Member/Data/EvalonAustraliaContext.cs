using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvalonAustralia.Models;

namespace EvalonAustralia.Data
{
    public class EvalonAustraliaContext : DbContext
    {
        public EvalonAustraliaContext (DbContextOptions<EvalonAustraliaContext> options)
            : base(options)
        {
        }

        public DbSet<EvalonAustralia.Models.Vehicle> Vehicle { get; set; }
    }
}
