using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LicensePlateDataAccess;
using LicensePlateModels;
using Microsoft.ApplicationInsights;

namespace LicensePlateWebAdminSystem.Controllers
{
    public class LicensePlatesController : Controller
    {
        private readonly LicensePlateDataDbContext _context;

        public TelemetryClient _telemetryClient { get; }

        public LicensePlatesController(LicensePlateDataDbContext context, TelemetryClient telemetryClient)
        {
            _context = context;
            _telemetryClient = telemetryClient;
        }

        // GET: LicensePlates
        public async Task<IActionResult> Index()
        {
            _telemetryClient.TrackEvent("LicensePlatesController.Index() called.");
            var plates = await _context.LicensePlates.ToListAsync();
            var count = plates?.Count() ?? 0;
            _telemetryClient.TrackTrace($"Current Plate count: {count}.");
            return count > 0 ? 
                    View(plates) :
                    Problem("Entity set 'LicensePlateDataDbContext.LicensePlates'  is null.");
        }

        // GET: LicensePlates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LicensePlates == null)
            {
                return NotFound();
            }

            var licensePlate = await _context.LicensePlates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licensePlate == null)
            {
                return NotFound();
            }

            return View(licensePlate);
        }

        // GET: LicensePlates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LicensePlates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsProcessed,FileName,LicensePlateText,TimeStamp")] LicensePlate licensePlate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licensePlate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licensePlate);
        }

        // GET: LicensePlates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LicensePlates == null)
            {
                return NotFound();
            }

            var licensePlate = await _context.LicensePlates.FindAsync(id);
            if (licensePlate == null)
            {
                return NotFound();
            }
            return View(licensePlate);
        }

        // POST: LicensePlates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsProcessed,FileName,LicensePlateText,TimeStamp")] LicensePlate licensePlate)
        {
            if (id != licensePlate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licensePlate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicensePlateExists(licensePlate.Id))
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
            return View(licensePlate);
        }

        // GET: LicensePlates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LicensePlates == null)
            {
                return NotFound();
            }

            var licensePlate = await _context.LicensePlates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licensePlate == null)
            {
                return NotFound();
            }

            return View(licensePlate);
        }

        // POST: LicensePlates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LicensePlates == null)
            {
                return Problem("Entity set 'LicensePlateDataDbContext.LicensePlates'  is null.");
            }
            var licensePlate = await _context.LicensePlates.FindAsync(id);
            if (licensePlate != null)
            {
                _context.LicensePlates.Remove(licensePlate);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicensePlateExists(int id)
        {
          return (_context.LicensePlates?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
