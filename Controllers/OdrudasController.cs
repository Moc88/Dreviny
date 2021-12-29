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
    public class OdrudasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OdrudasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Odrudas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Odruda.ToListAsync());
        }

        // GET: Odrudas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odruda = await _context.Odruda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odruda == null)
            {
                return NotFound();
            }

            return View(odruda);
        }

        // GET: Odrudas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Odrudas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NazevOdrudy,DruhStromu,Vzrust,Odolnost,Kveteni,Sklizeň,Plod,Ruzne")] Odruda odruda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odruda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(odruda);
        }

        // GET: Odrudas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odruda = await _context.Odruda.FindAsync(id);
            if (odruda == null)
            {
                return NotFound();
            }
            return View(odruda);
        }

        // POST: Odrudas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NazevOdrudy,DruhStromu,Vzrust,Odolnost,Kveteni,Sklizeň,Plod,Ruzne")] Odruda odruda)
        {
            if (id != odruda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odruda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OdrudaExists(odruda.Id))
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
            return View(odruda);
        }

        // GET: Odrudas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odruda = await _context.Odruda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odruda == null)
            {
                return NotFound();
            }

            return View(odruda);
        }

        // POST: Odrudas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var odruda = await _context.Odruda.FindAsync(id);
            _context.Odruda.Remove(odruda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OdrudaExists(int id)
        {
            return _context.Odruda.Any(e => e.Id == id);
        }
    }
}
