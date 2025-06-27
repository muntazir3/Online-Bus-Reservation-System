using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railwaiy_Eproject.Data;
using Railwaiy_Eproject.Models;

namespace Railwaiy_Eproject.Controllers
{
    public class SchedulingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchedulingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedulings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Scheduling.ToListAsync());
        }

        // GET: Schedulings/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduling = await _context.Scheduling
                .FirstOrDefaultAsync(m => m.StartStation == id);
            if (scheduling == null)
            {
                return NotFound();
            }

            return View(scheduling);
        }

        // GET: Schedulings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedulings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StartStation,EndStation,IntermediateStation,TotalDistance,ArrivalTime,DepartureTime,Train_Id")] Scheduling scheduling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduling);
        }

        // GET: Schedulings/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduling = await _context.Scheduling.FindAsync(id);
            if (scheduling == null)
            {
                return NotFound();
            }
            return View(scheduling);
        }

        // POST: Schedulings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StartStation,EndStation,IntermediateStation,TotalDistance,ArrivalTime,DepartureTime,Train_Id")] Scheduling scheduling)
        {
            if (id != scheduling.StartStation)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchedulingExists(scheduling.StartStation))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(scheduling);
        }

        // GET: Schedulings/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduling = await _context.Scheduling
                .FirstOrDefaultAsync(m => m.StartStation == id);
            if (scheduling == null)
            {
                return NotFound();
            }

            return View(scheduling);
        }

        // POST: Schedulings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var scheduling = await _context.Scheduling.FindAsync(id);
            if (scheduling != null)
            {
                _context.Scheduling.Remove(scheduling);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchedulingExists(string id)
        {
            return _context.Scheduling.Any(e => e.StartStation == id);
        }

        public async Task<IActionResult> FlightListing()
        {
            var schedules = await _context.Scheduling.ToListAsync(); // Asynchronously fetch data
            return View(schedules); // Pass the data to the view
        }

    }
}
