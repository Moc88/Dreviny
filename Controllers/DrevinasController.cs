using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dreviny.Data;
using dreviny.Models;

namespace dreviny.Controllers
{
    public class DrevinasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DrevinasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Drevinas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drevina.ToListAsync());
        }

        // GET: Drevinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drevina = await _context.Drevina
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drevina == null)
            {
                return NotFound();
            }

            return View(drevina);
        }

        // GET: Drevinas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drevinas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Strom,Vzrust,Vysadba,Stanoviste,Puda,Sprasnost,Odolnost,Rez,Hnojeni,Kveteni,Sklizeň,Zazimovani,Ruzne")] Drevina drevina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drevina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drevina);
        }

        // GET: Drevinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drevina = await _context.Drevina.FindAsync(id);
            if (drevina == null)
            {
                return NotFound();
            }
            return View(drevina);
        }

        // POST: Drevinas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Strom,Vzrust,Vysadba,Stanoviste,Puda,Sprasnost,Odolnost,Rez,Hnojeni,Kveteni,Sklizeň,Zazimovani,Ruzne")] Drevina drevina)
        {
            if (id != drevina.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drevina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrevinaExists(drevina.Id))
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
            return View(drevina);
        }

        // GET: Drevinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drevina = await _context.Drevina
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drevina == null)
            {
                return NotFound();
            }

            return View(drevina);
        }

        // POST: Drevinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drevina = await _context.Drevina.FindAsync(id);
            _context.Drevina.Remove(drevina);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrevinaExists(int id)
        {
            return _context.Drevina.Any(e => e.Id == id);
        }
    }
}
