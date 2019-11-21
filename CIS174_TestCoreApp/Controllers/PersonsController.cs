using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIS174_TestCoreApp;
using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Filters;
using Microsoft.Extensions.Logging;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers.api
{
    [HandleException]
    public class PersonsController : Controller
    {
        private readonly PersonContext _context;
        private readonly ILogger<PersonsController> _log;

        public PersonsController(PersonContext context, ILogger<PersonsController> log)
        {
            _context = context;
            _log = log;
        }

        // GET: Persons
        public async Task<IActionResult> Index()
        {
            _log.LogInformation("Getting persons to display");
            return View(await _context.Persons.ToListAsync());
        }

        // GET: Persons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                _log.LogWarning("The ID field is null, cannot search");
                return NotFound();
            }

            var person = await _context.Persons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                _log.LogWarning("There is no person with ID {id}", id);
                return NotFound();
            }

            _log.LogInformation("Found person with ID {id}", id);
            return View(person);
        }

        // GET: Persons/Create
        public IActionResult Create()
        {
            return View(new CreatePerson());
        }

        // POST: Persons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Birthday,City,State")] Person person)
        {
            if (ModelState.IsValid)
            {
                _log.LogInformation("Creating person");
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _log.LogWarning("The Model State to create a person was not valid");
            return View(person);
        }

        // GET: Persons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                _log.LogInformation("The id field is null, cannot edit");
                return NotFound();
            }

            var person = await _context.Persons.FindAsync(id);
            if (person == null)
            {
                _log.LogWarning("The person you are trying to edit does not exist, ID {id}", id);
                return NotFound();
            }
            return View(person);
        }

        // POST: Persons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Birthday,City,State")] Person person, [Bind("PersonId,Name,DateOfAccomplishment")] Accomplishment accomplishment)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (accomplishment != null)
                    {
                        person.SetOfAccomplishments.Add(accomplishment);
                    }
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _log.LogWarning("The person does not exist, ID {id}", id);
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        // GET: Persons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                _log.LogWarning("The id is null, cannot delete");
                return NotFound();
            }

            var person = await _context.Persons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                _log.LogWarning("The person you are trying to delete does not exist, ID {id}", id);
                return NotFound();
            }

            _log.LogInformation("Deleted person with ID {id}", id);
            return View(person);
        }

        // POST: Persons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Persons.FindAsync(id);
            _context.Persons.Remove(person);
            //await _context.SaveChangesAsync();
            _log.LogInformation("Deletion of person with ID {id}, has been confirmed", id);
            return RedirectToAction(nameof(Index));
        }


        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.Id == id);
        }
    }
}
