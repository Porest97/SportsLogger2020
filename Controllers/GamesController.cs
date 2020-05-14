﻿using System;
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
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Game
                .Include(g => g.Arena)
                .Include(g => g.AwayTeam)
                .Include(g => g.GameCategory)
                .Include(g => g.GameStatus)
                .Include(g => g.GameType)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.HomeTeam)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .Include(g => g.Series);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Arena)
                .Include(g => g.AwayTeam)
                .Include(g => g.GameCategory)
                .Include(g => g.GameStatus)
                .Include(g => g.GameType)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.HomeTeam)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .Include(g => g.Series)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id");
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "Id");
            ViewData["GameCategoryId"] = new SelectList(_context.Set<GameCategory>(), "Id", "Id");
            ViewData["GameStatusId"] = new SelectList(_context.Set<GameStatus>(), "Id", "Id");
            ViewData["GameTypeId"] = new SelectList(_context.Set<GameType>(), "Id", "Id");
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id");
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            ViewData["PersonId3"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            ViewData["SeriesId"] = new SelectList(_context.Set<Series>(), "Id", "Id");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameDateTime,GameNumber,TSMNumber,GameCategoryId,GameStatusId,GameTypeId,SeriesId,ArenaId,ClubId,ClubId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", game.ArenaId);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "Id", game.ClubId1);
            ViewData["GameCategoryId"] = new SelectList(_context.Set<GameCategory>(), "Id", "Id", game.GameCategoryId);
            ViewData["GameStatusId"] = new SelectList(_context.Set<GameStatus>(), "Id", "Id", game.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.Set<GameType>(), "Id", "Id", game.GameTypeId);
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId1);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id", game.ClubId);
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId3);
            ViewData["SeriesId"] = new SelectList(_context.Set<Series>(), "Id", "Id", game.SeriesId);
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", game.ArenaId);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "Id", game.ClubId1);
            ViewData["GameCategoryId"] = new SelectList(_context.Set<GameCategory>(), "Id", "Id", game.GameCategoryId);
            ViewData["GameStatusId"] = new SelectList(_context.Set<GameStatus>(), "Id", "Id", game.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.Set<GameType>(), "Id", "Id", game.GameTypeId);
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId1);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id", game.ClubId);
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId3);
            ViewData["SeriesId"] = new SelectList(_context.Set<Series>(), "Id", "Id", game.SeriesId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameDateTime,GameNumber,TSMNumber,GameCategoryId,GameStatusId,GameTypeId,SeriesId,ArenaId,ClubId,ClubId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", game.ArenaId);
            ViewData["ClubId1"] = new SelectList(_context.Club, "Id", "Id", game.ClubId1);
            ViewData["GameCategoryId"] = new SelectList(_context.Set<GameCategory>(), "Id", "Id", game.GameCategoryId);
            ViewData["GameStatusId"] = new SelectList(_context.Set<GameStatus>(), "Id", "Id", game.GameStatusId);
            ViewData["GameTypeId"] = new SelectList(_context.Set<GameType>(), "Id", "Id", game.GameTypeId);
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId1);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "Id", game.ClubId);
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Set<Person>(), "Id", "Id", game.PersonId3);
            ViewData["SeriesId"] = new SelectList(_context.Set<Series>(), "Id", "Id", game.SeriesId);
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Arena)
                .Include(g => g.AwayTeam)
                .Include(g => g.GameCategory)
                .Include(g => g.GameStatus)
                .Include(g => g.GameType)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.HomeTeam)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .Include(g => g.Series)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.Id == id);
        }
    }
}
