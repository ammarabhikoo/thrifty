using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tpi_website.Data;
using tpi_website.Models;

namespace tpi_website
{
    public class sproductsController : Controller
    {
        private readonly tpi_websiteContext _context;

        public sproductsController(tpi_websiteContext context)
        {
            _context = context;
        }

        // GET: sproducts
        public async Task<IActionResult> Index()
        {
              return _context.Thrifty != null ? 
                          View(await _context.Thrifty.ToListAsync()) :
                          Problem("Entity set 'tpi_websiteContext.Thrifty'  is null.");
        }

        // GET: sproducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Thrifty == null)
            {
                return NotFound();
            }

            var thrifty = await _context.Thrifty
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thrifty == null)
            {
                return NotFound();
            }

            return View(thrifty);
        }

        // GET: sproducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sproducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price")] Thrifty thrifty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thrifty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thrifty);
        }

        // GET: sproducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Thrifty == null)
            {
                return NotFound();
            }

            var thrifty = await _context.Thrifty.FindAsync(id);
            if (thrifty == null)
            {
                return NotFound();
            }
            return View(thrifty);
        }

        // POST: sproducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price")] Thrifty thrifty)
        {
            if (id != thrifty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thrifty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThriftyExists(thrifty.Id))
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
            return View(thrifty);
        }

        // GET: sproducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Thrifty == null)
            {
                return NotFound();
            }

            var thrifty = await _context.Thrifty
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thrifty == null)
            {
                return NotFound();
            }

            return View(thrifty);
        }

        // POST: sproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Thrifty == null)
            {
                return Problem("Entity set 'tpi_websiteContext.Thrifty'  is null.");
            }
            var thrifty = await _context.Thrifty.FindAsync(id);
            if (thrifty != null)
            {
                _context.Thrifty.Remove(thrifty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThriftyExists(int id)
        {
          return (_context.Thrifty?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
