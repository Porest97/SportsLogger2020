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
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Team.Include(t => t.Arena).Include(t => t.Club).Include(t => t.District).Include(t => t.Series).Include(t => t.TeamStatus);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .Include(t => t.Arena)
                .Include(t => t.Club)
                .Include(t => t.District)
                .Include(t => t.Series)
                .Include(t => t.TeamStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // GET: Teams/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id");
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "Id");
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id");
            ViewData["TeamStatusId"] = new SelectList(_context.Set<TeamStatus>(), "Id", "Id");
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamName,ClubId,DistrictId,ArenaId,SeriesId,TeamStatusId")] Team team)
        {
            if (ModelState.IsValid)
            {
                _context.Add(team);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", team.ArenaId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id", team.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "Id", team.DistrictId);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id", team.SeriesId);
            ViewData["TeamStatusId"] = new SelectList(_context.Set<TeamStatus>(), "Id", "Id", team.TeamStatusId);
            return View(team);
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", team.ArenaId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id", team.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "Id", team.DistrictId);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id", team.SeriesId);
            ViewData["TeamStatusId"] = new SelectList(_context.Set<TeamStatus>(), "Id", "Id", team.TeamStatusId);
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamName,ClubId,DistrictId,ArenaId,SeriesId,TeamStatusId")] Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", team.ArenaId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id", team.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "Id", team.DistrictId);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id", team.SeriesId);
            ViewData["TeamStatusId"] = new SelectList(_context.Set<TeamStatus>(), "Id", "Id", team.TeamStatusId);
            return View(team);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .Include(t => t.Arena)
                .Include(t => t.Club)
                .Include(t => t.District)
                .Include(t => t.Series)
                .Include(t => t.TeamStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.Team.FindAsync(id);
            _context.Team.Remove(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return _context.Team.Any(e => e.Id == id);
        }
    }
}
