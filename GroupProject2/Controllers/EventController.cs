using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupProject2.Data;
using GroupProject2.Models;
using GroupProject2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace GroupProject2.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IDAL _dal;

        public EventController(ApplicationDbContext context, IDAL dal)
        {
            _context = context;
            _dal = dal;
        }

        // GET: Event
        public IActionResult Index()
        {
            if (TempData["Alert"] != null)
            {
                ViewData["Alert"] = TempData["Alert"];
            }
            return View(_dal.GetEvents());
        }

        // GET: Event/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = _dal.GetEvent((int)id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Event/Create
        [Authorize]
        public IActionResult Create()
        {
            return View(new EventViewModel(_dal.GetLocations()));
        }

        // POST: Event/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        [Authorize]
        public IActionResult Create(EventViewModel vm)
        {
            try
            {
                var loc = _context.Locations.FirstOrDefault(x => x.Name == vm.SelectedLocationName); // Or use an ID
                vm.Event.Location = loc;

                _context.Events.Add(vm.Event);
                _context.SaveChanges();

                TempData["Alert"] = "Success! You created a new event for: " + vm.Event.Name;
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["Alert"] = "An error occurred: " + ex.Message;
                return View(vm);
            }
        }

        // GET: Event/Edit/5
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = _dal.GetEvent((int)id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, EventViewModel vm, IFormCollection form)
        {
            if (id != vm.Event.Id)
            {
                return NotFound();
            }

            
            try
            {
                _dal.UpdateEvent(form);
                TempData["Alert"] = "Success you modified an event for: " + vm.Event.Name;
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewData["Alert"] = "An error occurred: " + ex.Message;
                return View(vm);
            }
                
            
        }

        // GET: Event/Delete/5
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var @event = _dal.GetEvent((int)id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult DeleteConfirmed(int id)
        {
            var ev = _dal.GetEvent(id);
            if (ev != null)
            {
                _dal.DeleteEvent(id);
                TempData["Alert"] = $"You deleted event: {ev.Name}";
            }
            else
            {
                TempData["Alert"] = "Event not found.";
            }

            return RedirectToAction(nameof(Index));
        }


    }
}
