using CIS174_TestCoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePerson : EditPerson
    {
        public new IList<CreateAccomplishment> Accomplishments { get; set; } = new List<CreateAccomplishment>();

        public Person ToPerson()
        {
            return new Person
            {
                FirstName = FirstName,
                LastName = LastName,
                Birthday = Birthday,
                City = City,
                State = State,
                SetOfAccomplishments = Accomplishments.Select(x => x.ToAccomplishment()).ToList(),
            };
        }
    }
}
