using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsLogger.Data;
using SportsLogger.Models.DataModels;

namespace SportsLogger.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Receipts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Receipt
                .Include(r => r.Game)
                .Include(r => r.ReceiptCategory)
                .Include(r => r.ReceiptStatus)
                .Include(r => r.ReceiptType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Receipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt
                .Include(r => r.Game)
                .Include(r => r.ReceiptCategory)
                .Include(r => r.ReceiptStatus)
                .Include(r => r.ReceiptType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // GET: Receipts/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["ReceiptCategoryId"] = new SelectList(_context.Set<ReceiptCategory>(), "Id", "Id");
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id");
            ViewData["ReceiptTypeId"] = new SelectList(_context.Set<ReceiptType>(), "Id", "Id");
            return View();
        }

        // POST: Receipts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReceiptCategoryId,ReceiptStatusId,ReceiptTypeId,GameId,HD1Fee,HD1TravelKost,HD1Alowens,HD1LateGameKost,HD1Other,HD1TotalFee,HD2Fee,HD2TravelKost,HD2Alowens,HD2LateGameKost,HD2Other,HD2TotalFee,LD1Fee,LD1TravelKost,LD1Alowens,LD1LateGameKost,LD1Other,LD1TotalFee,LD2Fee,LD2TravelKost,LD2Alowens,LD2LateGameKost,LD2Other,LD2TotalFee,GameTotalKost,AmountPaidHD1,AmountPaidHD2,AmountPaidLD1,AmountPaidLD2,TotalAmountPaid,TotalAmountToPay,HalfTotalAmountToPay")] Receipt receipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", receipt.GameId);
            ViewData["ReceiptCategoryId"] = new SelectList(_context.Set<ReceiptCategory>(), "Id", "Id", receipt.ReceiptCategoryId);
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id", receipt.ReceiptStatusId);
            ViewData["ReceiptTypeId"] = new SelectList(_context.Set<ReceiptType>(), "Id", "Id", receipt.ReceiptTypeId);
            return View(receipt);
        }

        // GET: Receipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", receipt.GameId);
            ViewData["ReceiptCategoryId"] = new SelectList(_context.Set<ReceiptCategory>(), "Id", "Id", receipt.ReceiptCategoryId);
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id", receipt.ReceiptStatusId);
            ViewData["ReceiptTypeId"] = new SelectList(_context.Set<ReceiptType>(), "Id", "Id", receipt.ReceiptTypeId);
            return View(receipt);
        }

        // POST: Receipts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReceiptCategoryId,ReceiptStatusId,ReceiptTypeId,GameId,HD1Fee,HD1TravelKost,HD1Alowens,HD1LateGameKost,HD1Other,HD1TotalFee,HD2Fee,HD2TravelKost,HD2Alowens,HD2LateGameKost,HD2Other,HD2TotalFee,LD1Fee,LD1TravelKost,LD1Alowens,LD1LateGameKost,LD1Other,LD1TotalFee,LD2Fee,LD2TravelKost,LD2Alowens,LD2LateGameKost,LD2Other,LD2TotalFee,GameTotalKost,AmountPaidHD1,AmountPaidHD2,AmountPaidLD1,AmountPaidLD2,TotalAmountPaid,TotalAmountToPay,HalfTotalAmountToPay")] Receipt receipt)
        {
            if (id != receipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceiptExists(receipt.Id))
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
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", receipt.GameId);
            ViewData["ReceiptCategoryId"] = new SelectList(_context.Set<ReceiptCategory>(), "Id", "Id", receipt.ReceiptCategoryId);
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id", receipt.ReceiptStatusId);
            ViewData["ReceiptTypeId"] = new SelectList(_context.Set<ReceiptType>(), "Id", "Id", receipt.ReceiptTypeId);
            return View(receipt);
        }

        // GET: Receipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt
                .Include(r => r.Game)
                .Include(r => r.ReceiptCategory)
                .Include(r => r.ReceiptStatus)
                .Include(r => r.ReceiptType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // POST: Receipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receipt = await _context.Receipt.FindAsync(id);
            _context.Receipt.Remove(receipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceiptExists(int id)
        {
            return _context.Receipt.Any(e => e.Id == id);
        }
    }
}
