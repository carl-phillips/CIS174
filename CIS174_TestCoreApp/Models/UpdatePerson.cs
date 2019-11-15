using CIS174_TestCoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class UpdatePerson : EditPerson
    {
        public int Id { get; set; }

        public void UpdatePersons(Person person)
        {
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Birthday = Birthday;
            person.City = City;
            person.State = State;
        }
    }
}
