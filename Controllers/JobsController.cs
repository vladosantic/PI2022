using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PI2022.Data;
using PI2022.Models;

namespace PI2022
{
    public class JobsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            return _context.Jobs != null ?
                        View(await _context.Jobs.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Jobs'  is null.");
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            var jobs = from m in _context.Jobs
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                jobs = jobs.Where(s => s.Naziv!.Contains(searchString));
            }

            return View(await jobs.ToListAsync());
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Jobs == null)
            {
                return NotFound();
            }

            var jobs = await _context.Jobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobs == null)
            {
                return NotFound();
            }

            return View(jobs);
        }

        // GET: Jobs/Create
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateFromOffer(int Id)
        {
            var offer = await _context.Offers.FindAsync(Id);
            if (offer == null)
            {
                return View("Error");
            }
            var random = new Random();
            var broj = random.NextDouble() * (5 - 1) + 1;
            var model = new Jobs
            {
                Naziv = offer.Naziv,
                OpisPosla = offer.OpisPosla,
                BrojOsoba = offer.BrojOsoba,
                BrojSati = offer.BrojSati,
                CijenaSata = offer.CijenaSata,
                PotrebnaOprema = offer.PotrebnaOprema,
                PocetakRadova = offer.PocetakRadova,
                ZavrsetakRadova = offer.ZavrsetakRadova,
                Trosak = offer.BrojOsoba * offer.BrojSati * offer.CijenaSata,
                Profit = (offer.BrojOsoba * offer.BrojSati * offer.CijenaSata) * broj
            };
            await _context.SaveChangesAsync();
            return View(model);
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,OpisPosla,BrojOsoba,BrojSati,CijenaSata,PotrebnaOprema,PotrebniCertifikati,Adresa,PocetakRadova,ZavrsetakRadova,Trosak")] Jobs jobs)
        {
            if (ModelState.IsValid)
            {
                var random = new Random();
                var broj = random.NextDouble() * (5 - 1) + 1;
                jobs.Profit = (jobs.BrojOsoba * jobs.BrojSati * jobs.CijenaSata) * broj;
                jobs.Trosak = jobs.BrojOsoba * jobs.BrojSati * jobs.CijenaSata;
                _context.Add(jobs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobs);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Jobs == null)
            {
                return NotFound();
            }

            var jobs = await _context.Jobs.FindAsync(id);
            if (jobs == null)
            {
                return NotFound();
            }
            return View(jobs);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,OpisPosla,BrojOsoba,BrojSati,CijenaSata,PotrebnaOprema,PotrebniCertifikati,Adresa,PocetakRadova,ZavrsetakRadova,Trosak")] Jobs jobs)
        {
            if (id != jobs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var random = new Random();
                    var broj = random.NextDouble() * (5 - 1) + 1;
                    jobs.Profit = (jobs.BrojOsoba * jobs.BrojSati * jobs.CijenaSata) * broj;
                    jobs.Trosak = jobs.BrojOsoba * jobs.BrojSati * jobs.CijenaSata;
                    _context.Update(jobs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobsExists(jobs.Id))
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
            return View(jobs);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Jobs == null)
            {
                return NotFound();
            }

            var jobs = await _context.Jobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobs == null)
            {
                return NotFound();
            }

            return View(jobs);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Jobs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Jobs'  is null.");
            }
            var jobs = await _context.Jobs.FindAsync(id);
            if (jobs != null)
            {
                _context.Jobs.Remove(jobs);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobsExists(int id)
        {
            return (_context.Jobs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}