using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Shop.Data;
using E_Shop_DATN.Models;

namespace E_Shop.Controllers
{
    public class ImportedInvoicesController : Controller
    {
        private readonly E_ShopContext _context;

        public ImportedInvoicesController(E_ShopContext context)
        {
            _context = context;
        }

        // GET: ImportedInvoices
        public async Task<IActionResult> Index()
        {
            var e_ShopContext = _context.ImportedInvoice.Include(i => i.Admin);
            return View(await e_ShopContext.ToListAsync());
        }

        // GET: ImportedInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ImportedInvoice == null)
            {
                return NotFound();
            }

            var importedInvoice = await _context.ImportedInvoice
                .Include(i => i.Admin)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importedInvoice == null)
            {
                return NotFound();
            }

            return View(importedInvoice);
        }

        // GET: ImportedInvoices/Create
        public IActionResult Create()
        {
            ViewData["AdminId"] = new SelectList(_context.Admin, "Id", "Id");
            return View();
        }

        // POST: ImportedInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdminId,DateImport,Total,Status")] ImportedInvoice importedInvoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(importedInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminId"] = new SelectList(_context.Admin, "Id", "Id", importedInvoice.AdminId);
            return View(importedInvoice);
        }

        // GET: ImportedInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ImportedInvoice == null)
            {
                return NotFound();
            }

            var importedInvoice = await _context.ImportedInvoice.FindAsync(id);
            if (importedInvoice == null)
            {
                return NotFound();
            }
            ViewData["AdminId"] = new SelectList(_context.Admin, "Id", "Id", importedInvoice.AdminId);
            return View(importedInvoice);
        }

        // POST: ImportedInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdminId,DateImport,Total,Status")] ImportedInvoice importedInvoice)
        {
            if (id != importedInvoice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(importedInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImportedInvoiceExists(importedInvoice.Id))
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
            ViewData["AdminId"] = new SelectList(_context.Admin, "Id", "Id", importedInvoice.AdminId);
            return View(importedInvoice);
        }

        // GET: ImportedInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ImportedInvoice == null)
            {
                return NotFound();
            }

            var importedInvoice = await _context.ImportedInvoice
                .Include(i => i.Admin)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importedInvoice == null)
            {
                return NotFound();
            }

            return View(importedInvoice);
        }

        // POST: ImportedInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ImportedInvoice == null)
            {
                return Problem("Entity set 'E_ShopContext.ImportedInvoice'  is null.");
            }
            var importedInvoice = await _context.ImportedInvoice.FindAsync(id);
            if (importedInvoice != null)
            {
                _context.ImportedInvoice.Remove(importedInvoice);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImportedInvoiceExists(int id)
        {
          return (_context.ImportedInvoice?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
