using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class PersonsAccomplishments
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Date of Accomplishment")]
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
