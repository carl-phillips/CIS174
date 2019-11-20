using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public class PersonService
    {
        readonly PersonContext _personContext;
        readonly ILogger _logger;

        public PersonService(PersonContext personContext, ILoggerFactory factory)
        {
            _personContext = personContext;
            _logger = factory.CreateLogger<PersonService>();
        }
        
        public ICollection<FamousPerson> GetPeople()
        {
            _logger.LogInformation("Loading famous people information");

            return _personContext.Persons
                .Where(p => !p.IsDeleted)
                .Select(p => new FamousPerson
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    NumberOfAccomplishments = p.SetOfAccomplishments.Count,
                })
                .ToList();
        }

        public ICollection<PersonsAccomplishments> GetAccomplishments()
        {
            _logger.LogInformation("Loading accomplishments");

            return _personContext.Accomplishments
                .Select(a => new PersonsAccomplishments
                {
                    PersonId = a.PersonId,
                    Id = a.Id,
                    Name = a.Name,
                    DateOfAccomplishment = a.DateOfAccomplishment,
                }).ToList();
        }

        public bool IsNameCorrect(string first, string last)
        {
            _logger.LogInformation("Checking if name is correct");

            return _personContext.Persons
                .Where(r => !r.IsDeleted)
                .Where(r => r.FirstName == first)
                .Where(r => r.LastName == last)
                .Any();
        }

        public UpdatePerson GetPersonForUpdate(int Id)
        {
            _logger.LogInformation("Getting person for update, ID: ", Id);

            return _personContext.Persons
                .Where(x => x.Id == Id)
                .Where(x => !x.IsDeleted)
                .Select(x => new UpdatePerson
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Birthday = x.Birthday,
                    City = x.City,
                    State = x.State,
                })
                .SingleOrDefault();
        }

        public int CreatePerson(CreatePerson cmd)
        {
            _logger.LogInformation("Creating person");

            var person = cmd.ToPerson();
            _personContext.Add(person);
            _personContext.SaveChanges();
            return person.Id;
        }

        //[Authorize]
        //public IActionResult Edit(int id)
        //{
        //    var model = _service.GetPersonForUpdate(id);
        //    if (model == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(model);
        //}

        //private IActionResult NotFound()
        //{
        //    throw new NotImplementedException();
        //}

        //[HttpPost]
        //public IActionResult Edit(UpdatePerson command)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _service.UpdatePerson(command);
        //            return RedirectToAction(nameof(View), new { id = command.Id });
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        ModelState.AddModelError(
        //            string.Empty,
        //            "An error occured saving the person"
        //            );
        //    }

        //    return View(command);
        //}

        //[HttpPost, Authorize]
        //public IActionResult Create(CreatePerson command)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var id = _service.CreatePerson(command);
        //            return RedirectToAction(nameof(View), new { id = id });
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        ModelState.AddModelError(
        //            string.Empty,
        //            "An error occured saving the person"
        //            );
        //    }
        //    return View(command);
        //}

        public void UpdatePerson(UpdatePerson cmd)
        {
            var person = _personContext.Persons.Find(cmd.Id);
            if (person == null) 
            {
                _logger.LogError("This is no person with ID: ", cmd.Id);
                throw new Exception("Unable to find the person"); 
            }
            if (person.IsDeleted) 
            {
                _logger.LogError("Unable to update deleted person with ID: ", cmd.Id);
                throw new Exception("Unable to update a deleted person"); 
            }

            _logger.LogInformation("Getting information for person with ID: ", cmd.Id);
            cmd.UpdatePersons(person);
            _personContext.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var person = _personContext.Persons.Find(id);
            if (person.IsDeleted) { throw new Exception("Unable to delete a deleted person"); }

            _logger.LogInformation("Deleting person with ID: ", id);
            person.IsDeleted = true;
            _personContext.SaveChanges();
        }

        public bool DoesPersonExist(int id)
        {
            var person = _personContext.Persons.Find(id);

            if (person == null)
            {
                _logger.LogWarning("This person does not exist, ID: ", id);
                return false;
            }

            return true;
        }
    }
}
