using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class PersonsAccomplishments
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfAccomplishment { get; set; }

        public static PersonsAccomplishments FromAccomplishment(PersonsAccomplishments accomplishment, FamousPerson person)
        {
            return new PersonsAccomplishments
            {
                PersonId = person.Id,
                Id = accomplishment.Id,
                Name = accomplishment.Name,
                DateOfAccomplishment = accomplishment.DateOfAccomplishment,
            };
        }
    }
}
