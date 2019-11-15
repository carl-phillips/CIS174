using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class FamousPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfAccomplishments { get; set; }

        public static FamousPerson FromFamousPerson(FamousPerson person)
        {
            return new FamousPerson
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
            };
        }
    }
}
