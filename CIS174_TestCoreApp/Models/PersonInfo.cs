using CIS174_TestCoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class PersonInfo
    {
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public IEnumerable<Accomplishment> Accomplishments { get; set; }

        public class Accomplishment
        {
            public string Name { get; set; }
            public DateTime DateOfAccomplishment { get; set; }
        }
    }
}
