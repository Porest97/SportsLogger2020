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
    public class TournamentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TournamentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tournaments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tournament
                .Include(t => t.Game1)
                .Include(t => t.Game10)
                .Include(t => t.Game11)
                .Include(t => t.Game12)
                .Include(t => t.Game13)
                .Include(t => t.Game14)
                .Include(t => t.Game15)
                .Include(t => t.Game2)
                .Include(t => t.Game3)
                .Include(t => t.Game4)
                .Include(t => t.Game5)
                .Include(t => t.Game6)
                .Include(t => t.Game7)
                .Include(t => t.Game8)
                .Include(t => t.Game9)
                .Include(t => t.TournamentType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tournaments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament
                .Include(t => t.Game1)
                .Include(t => t.Game10)
                .Include(t => t.Game11)
                .Include(t => t.Game12)
                .Include(t => t.Game13)
                .Include(t => t.Game14)
                .Include(t => t.Game15)
                .Include(t => t.Game2)
                .Include(t => t.Game3)
                .Include(t => t.Game4)
                .Include(t => t.Game5)
                .Include(t => t.Game6)
                .Include(t => t.Game7)
                .Include(t => t.Game8)
                .Include(t => t.Game9)
                .Include(t => t.TournamentType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        // GET: Tournaments/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId9"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId10"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId11"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId12"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId13"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId14"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId1"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId2"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId3"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId4"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId5"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId6"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId7"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["GameId8"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["TournamentTypeId"] = new SelectList(_context.TournamentType, "Id", "Id");
            return View();
        }

        // POST: Tournaments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TournamentName,TournamentDateTime,TournamentTypeId,GameId,GameId1,GameId2,GameId3,GameId4,GameId5,GameId6,GameId7,GameId8,GameId9,GameId10,GameId11,GameId12,GameId13,GameId14")] Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId);
            ViewData["GameId9"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId9);
            ViewData["GameId10"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId10);
            ViewData["GameId11"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId11);
            ViewData["GameId12"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId12);
            ViewData["GameId13"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId13);
            ViewData["GameId14"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId14);
            ViewData["GameId1"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId1);
            ViewData["GameId2"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId2);
            ViewData["GameId3"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId3);
            ViewData["GameId4"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId4);
            ViewData["GameId5"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId5);
            ViewData["GameId6"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId6);
            ViewData["GameId7"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId7);
            ViewData["GameId8"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId8);
            ViewData["TournamentTypeId"] = new SelectList(_context.TournamentType, "Id", "Id", tournament.TournamentTypeId);
            return View(tournament);
        }

        // GET: Tournaments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament.FindAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId);
            ViewData["GameId9"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId9);
            ViewData["GameId10"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId10);
            ViewData["GameId11"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId11);
            ViewData["GameId12"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId12);
            ViewData["GameId13"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId13);
            ViewData["GameId14"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId14);
            ViewData["GameId1"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId1);
            ViewData["GameId2"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId2);
            ViewData["GameId3"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId3);
            ViewData["GameId4"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId4);
            ViewData["GameId5"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId5);
            ViewData["GameId6"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId6);
            ViewData["GameId7"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId7);
            ViewData["GameId8"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId8);
            ViewData["TournamentTypeId"] = new SelectList(_context.TournamentType, "Id", "Id", tournament.TournamentTypeId);
            return View(tournament);
        }

        // POST: Tournaments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TournamentName,TournamentDateTime,TournamentTypeId,GameId,GameId1,GameId2,GameId3,GameId4,GameId5,GameId6,GameId7,GameId8,GameId9,GameId10,GameId11,GameId12,GameId13,GameId14")] Tournament tournament)
        {
            if (id != tournament.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentExists(tournament.Id))
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
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId);
            ViewData["GameId9"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId9);
            ViewData["GameId10"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId10);
            ViewData["GameId11"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId11);
            ViewData["GameId12"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId12);
            ViewData["GameId13"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId13);
            ViewData["GameId14"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId14);
            ViewData["GameId1"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId1);
            ViewData["GameId2"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId2);
            ViewData["GameId3"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId3);
            ViewData["GameId4"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId4);
            ViewData["GameId5"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId5);
            ViewData["GameId6"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId6);
            ViewData["GameId7"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId7);
            ViewData["GameId8"] = new SelectList(_context.Game, "Id", "Id", tournament.GameId8);
            ViewData["TournamentTypeId"] = new SelectList(_context.TournamentType, "Id", "Id", tournament.TournamentTypeId);
            return View(tournament);
        }

        // GET: Tournaments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament
                .Include(t => t.Game1)
                .Include(t => t.Game10)
                .Include(t => t.Game11)
                .Include(t => t.Game12)
                .Include(t => t.Game13)
                .Include(t => t.Game14)
                .Include(t => t.Game15)
                .Include(t => t.Game2)
                .Include(t => t.Game3)
                .Include(t => t.Game4)
                .Include(t => t.Game5)
                .Include(t => t.Game6)
                .Include(t => t.Game7)
                .Include(t => t.Game8)
                .Include(t => t.Game9)
                .Include(t => t.TournamentType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        // POST: Tournaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournament = await _context.Tournament.FindAsync(id);
            _context.Tournament.Remove(tournament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentExists(int id)
        {
            return _context.Tournament.Any(e => e.Id == id);
        }
    }
}
