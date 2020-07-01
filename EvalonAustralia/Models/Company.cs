using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalonAustralia.Models
{
    public class Company
    {
        public Company()
        {
            People = new List<Person>();
            Vehicles = new List<Vehicle>();
        }
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public List<Person> People { get; set; } 
        public List<Vehicle> Vehicles { get; set; }
         
    }
}
 