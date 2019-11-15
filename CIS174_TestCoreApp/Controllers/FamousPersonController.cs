using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using CIS174_TestCoreApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class FamousPersonController : Controller
    {
        private readonly PersonService _service;
        private readonly UserManager<ApplicationUser> _userService;
        private readonly IAuthorizationService _authService;

        public FamousPersonController(
            PersonService service,
            UserManager<ApplicationUser> userService,
            IAuthorizationService authService)
        {
            _service = service;
            _userService = userService;
            _authService = authService;
        }

        //GET: FamousPerson
        public ActionResult Index()
        {
            var models = _service.GetPeople();

            return View(models);
        }

        [Authorize]
        public IActionResult Accomplishments()
        {
            var model = _service.GetAccomplishments();

            return View(model);
        }

        //GET: FamousPerson/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: FamousPerson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamousPerson/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamousPerson/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FamousPerson/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamousPerson/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FamousPerson/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}