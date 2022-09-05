using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PI2022.Data;
using PI2022.Models;

namespace PI2022.Controllers
{
    public class BiddingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BiddingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Biddings
        public async Task<IActionResult> Index()
        {
              return _context.Bidding != null ? 
                          View(await _context.Bidding.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Bidding'  is null.");
        }

        // GET: Biddings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bidding == null)
            {
                return NotFound();
            }

            var bidding = await _context.Bidding
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bidding == null)
            {
                return NotFound();
            }

            return View(bidding);
        }

        // GET: Biddings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Biddings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Opis,ProcijenjenaVrijednost,Trajanje,Objavljen,Dobitnik")] Bidding bidding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bidding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bidding);
        }

        // GET: Biddings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bidding == null)
            {
                return NotFound();
            }

            var bidding = await _context.Bidding.FindAsync(id);
            if (bidding == null)
            {
                return NotFound();
            }
            return View(bidding);
        }

        // POST: Biddings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Opis,ProcijenjenaVrijednost,Trajanje,Objavljen,Dobitnik")] Bidding bidding)
        {
            if (id != bidding.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bidding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BiddingExists(bidding.Id))
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
            return View(bidding);
        }

        // GET: Biddings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bidding == null)
            {
                return NotFound();
            }

            var bidding = await _context.Bidding
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bidding == null)
            {
                return NotFound();
            }

            return View(bidding);
        }

        // POST: Biddings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bidding == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Bidding'  is null.");
            }
            var bidding = await _context.Bidding.FindAsync(id);
            if (bidding != null)
            {
                _context.Bidding.Remove(bidding);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BiddingExists(int id)
        {
          return (_context.Bidding?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
