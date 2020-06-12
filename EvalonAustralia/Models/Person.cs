using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalonAustralia.Models
{
    public class Person
    {
        public Person()
        {
            Vehicles = new List<Vehicle>();
        }
        

        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Vehicle> Vehicles { get; set; }




    }
}
