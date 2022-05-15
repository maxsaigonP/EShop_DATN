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
    public class ImportecInvoiceDetailsController : Controller
    {
        private readonly E_ShopContext _context;

        public ImportecInvoiceDetailsController(E_ShopContext context)
        {
            _context = context;
        }

        // GET: ImportecInvoiceDetails
        public async Task<IActionResult> Index()
        {
            var e_ShopContext = _context.ImportecInvoiceDetail.Include(i => i.ImportedInvoice).Include(i => i.Product);
            return View(await e_ShopContext.ToListAsync());
        }

        // GET: ImportecInvoiceDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ImportecInvoiceDetail == null)
            {
                return NotFound();
            }

            var importecInvoiceDetail = await _context.ImportecInvoiceDetail
                .Include(i => i.ImportedInvoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importecInvoiceDetail == null)
            {
                return NotFound();
            }

            return View(importecInvoiceDetail);
        }

        // GET: ImportecInvoiceDetails/Create
        public IActionResult Create()
        {
            ViewData["ImportedInvoiceId"] = new SelectList(_context.ImportedInvoice, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Description");
            return View();
        }

        // POST: ImportecInvoiceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImportedInvoiceId,ProductId,Quantity,Price")] ImportecInvoiceDetail importecInvoiceDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(importecInvoiceDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImportedInvoiceId"] = new SelectList(_context.ImportedInvoice, "Id", "Id", importecInvoiceDetail.ImportedInvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Description", importecInvoiceDetail.ProductId);
            return View(importecInvoiceDetail);
        }

        // GET: ImportecInvoiceDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ImportecInvoiceDetail == null)
            {
                return NotFound();
            }

            var importecInvoiceDetail = await _context.ImportecInvoiceDetail.FindAsync(id);
            if (importecInvoiceDetail == null)
            {
                return NotFound();
            }
            ViewData["ImportedInvoiceId"] = new SelectList(_context.ImportedInvoice, "Id", "Id", importecInvoiceDetail.ImportedInvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Description", importecInvoiceDetail.ProductId);
            return View(importecInvoiceDetail);
        }

        // POST: ImportecInvoiceDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImportedInvoiceId,ProductId,Quantity,Price")] ImportecInvoiceDetail importecInvoiceDetail)
        {
            if (id != importecInvoiceDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(importecInvoiceDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImportecInvoiceDetailExists(importecInvoiceDetail.Id))
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
            ViewData["ImportedInvoiceId"] = new SelectList(_context.ImportedInvoice, "Id", "Id", importecInvoiceDetail.ImportedInvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Description", importecInvoiceDetail.ProductId);
            return View(importecInvoiceDetail);
        }

        // GET: ImportecInvoiceDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ImportecInvoiceDetail == null)
            {
                return NotFound();
            }

            var importecInvoiceDetail = await _context.ImportecInvoiceDetail
                .Include(i => i.ImportedInvoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importecInvoiceDetail == null)
            {
                return NotFound();
            }

            return View(importecInvoiceDetail);
        }

        // POST: ImportecInvoiceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ImportecInvoiceDetail == null)
            {
                return Problem("Entity set 'E_ShopContext.ImportecInvoiceDetail'  is null.");
            }
            var importecInvoiceDetail = await _context.ImportecInvoiceDetail.FindAsync(id);
            if (importecInvoiceDetail != null)
            {
                _context.ImportecInvoiceDetail.Remove(importecInvoiceDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImportecInvoiceDetailExists(int id)
        {
          return (_context.ImportecInvoiceDetail?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
