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
    public class ReferencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReferencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: References
        public async Task<IActionResult> Index()
        {
              return _context.References != null ? 
                          View(await _context.References.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.References'  is null.");
        }

        // GET: References/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.References == null)
            {
                return NotFound();
            }

            var references = await _context.References
                .FirstOrDefaultAsync(m => m.Id == id);
            if (references == null)
            {
                return NotFound();
            }

            return View(references);
        }

        // GET: References/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: References/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Kategorija,Opis, Dobavljac, CijenaReferentneOpreme")] References references)
        {
            if (ModelState.IsValid)
            {
                _context.Add(references);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(references);
        }

        // GET: References/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.References == null)
            {
                return NotFound();
            }

            var references = await _context.References.FindAsync(id);
            if (references == null)
            {
                return NotFound();
            }
            return View(references);
        }

        // POST: References/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Kategorija,Opis, Dobavljac, CijenaReferentneOpreme")] References references)
        {
            if (id != references.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(references);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferencesExists(references.Id))
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
            return View(references);
        }

        // GET: References/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.References == null)
            {
                return NotFound();
            }

            var references = await _context.References
                .FirstOrDefaultAsync(m => m.Id == id);
            if (references == null)
            {
                return NotFound();
            }

            return View(references);
        }

        // POST: References/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.References == null)
            {
                return Problem("Entity set 'ApplicationDbContext.References'  is null.");
            }
            var references = await _context.References.FindAsync(id);
            if (references != null)
            {
                _context.References.Remove(references);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferencesExists(int id)
        {
          return (_context.References?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
