using EvalonAustralia.Models;
using EvalonAustralia.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalonAustralia.Data
{
    public class VehiclesService
    {

        private readonly ApplicationDbContext _context;


        public VehiclesService(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<VehiclesViewModels> GetAllVehicles()
        {
            var allVehicles = new List<Vehicle>();
            allVehicles = await _context.Vehicles.ToListAsync();
            var vm = new VehiclesViewModels
            {
                Vehicles = allVehicles
            };

            return vm;
        }


    }
}
