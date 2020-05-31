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
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Person> People { get; set; }

    }
}
