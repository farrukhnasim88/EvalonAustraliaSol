using System;
using System.Collections.Generic;
using System.Text;
using EvalonAustralia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EvalonAustralia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Person> People { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Company> Companies { get; set; }


    }
}
