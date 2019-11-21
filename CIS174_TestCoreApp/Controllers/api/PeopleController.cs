using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIS174_TestCoreApp;
using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Filters;
using Microsoft.Extensions.Logging;

namespace CIS174_TestCoreApp.Controllers.api
{
    [LogResourceFilter]
    [HandleException]
    [FeatureEnabled(IsEnabled = true)]
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        private readonly PersonContext _context;
        private ILogger<PeopleController> _logger;

        public PeopleController(PersonContext context, LogContext logContext, ILogger<PeopleController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/People
        [HttpGet]
        public IEnumerable<Person> GetPersons()
        {
            _logger.LogInformation("Getting persons to display");
            return _context.Persons;
        }

        // GET: api/People/5
        [ValidateModel]
        [Route("get")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson([FromRoute] int id)
        {
            var person = await _context.Persons.FindAsync(id);
            if(person == null)
            {
                _logger.LogWarning("Person with ID: {PersonId} not found", id);
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/People/5
        [ValidateModel]
        [Route("put")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson([FromRoute] int id, [FromBody] Person person)
        {

            if (id != person.Id)
            {
                _logger.LogWarning("ID {id} does not equal person ID", id);
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    _logger.LogWarning("Could not put person with ID {id}", id);
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            _logger.LogInformation("Put person with ID {id}", id);
            return NoContent();
        }

        // PUT: api/People/5
        [ValidatePerson]
        [Route("update")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson([FromRoute] int id, [FromBody] Person person)
        {

            if (id != person.Id)
            {
                _logger.LogWarning("ID {id} does not equal person ID", id);
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    _logger.LogWarning("Could not update person with ID {id}", id);
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            _logger.LogInformation("Updated person with ID {id}", id);
            return NoContent();
        }

        // POST: api/People
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> PostPerson([FromBody] Person person)
        {

            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        } 

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        [Route("delete")]
        public async Task<IActionResult> DeletePerson([FromRoute] int id)
        {

            var person = await _context.Persons.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();

            return Ok(person);
        }

        private bool PersonExists(int id)
        {
            _logger.LogInformation("Checking if person with ID {id} exists", id);
            return _context.Persons.Any(e => e.Id == id);
        }
    }
}