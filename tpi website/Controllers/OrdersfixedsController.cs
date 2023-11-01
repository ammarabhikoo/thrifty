using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tpi_website.Data;
using tpi_website.Models;

namespace tpi_website.Controllers
{
    public class OrdersfixedsController : Controller
    {
        private readonly tpi_websiteContext _context;

        public OrdersfixedsController(tpi_websiteContext context)
        {
            _context = context;
        }

        // GET: Ordersfixeds
        public async Task<IActionResult> Index()
        {
              return _context.Ordersfixed != null ? 
                          View(await _context.Ordersfixed.ToListAsync()) :
                          Problem("Entity set 'tpi_websiteContext.Ordersfixed'  is null.");
        }

        // GET: Ordersfixeds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ordersfixed == null)
            {
                return NotFound();
            }

            var ordersfixed = await _context.Ordersfixed
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersfixed == null)
            {
                return NotFound();
            }

            return View(ordersfixed);
        }

        // GET: Ordersfixeds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ordersfixeds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,To_street,To_city,To_zip,OrderDate,ProductName")] Ordersfixed ordersfixed)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordersfixed);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordersfixed);
        }

        // GET: Ordersfixeds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ordersfixed == null)
            {
                return NotFound();
            }

            var ordersfixed = await _context.Ordersfixed.FindAsync(id);
            if (ordersfixed == null)
            {
                return NotFound();
            }
            return View(ordersfixed);
        }

        // POST: Ordersfixeds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,To_street,To_city,To_zip,OrderDate,ProductName")] Ordersfixed ordersfixed)
        {
            if (id != ordersfixed.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordersfixed);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersfixedExists(ordersfixed.Id))
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
            return View(ordersfixed);
        }

        // GET: Ordersfixeds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ordersfixed == null)
            {
                return NotFound();
            }

            var ordersfixed = await _context.Ordersfixed
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersfixed == null)
            {
                return NotFound();
            }

            return View(ordersfixed);
        }

        // POST: Ordersfixeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ordersfixed == null)
            {
                return Problem("Entity set 'tpi_websiteContext.Ordersfixed'  is null.");
            }
            var ordersfixed = await _context.Ordersfixed.FindAsync(id);
            if (ordersfixed != null)
            {
                _context.Ordersfixed.Remove(ordersfixed);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersfixedExists(int id)
        {
          return (_context.Ordersfixed?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
