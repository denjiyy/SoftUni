using GameZone.Data;
using GameZone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Security.Claims;

namespace GameZone.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly GameZoneDbContext _context;

        public GameController(GameZoneDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> All()
        {
            var games = await _context.Games
                .Select(g => new GameInfoViewModel(
                    g.Id,
                    g.Title,
                    g.ReleasedOn,
                    g.Genre.Name,
                    g.ImageUrl,
                    g.Publisher.UserName
                ))
                .ToListAsync();

            return View(games);
        }

        public async Task<IActionResult> AddToMyZone(int id)
        {
            var game = await _context.Games
                .Where(g => g.Id == id)
                .Include(g => g.GamersGames)
                .FirstOrDefaultAsync();

            if (game == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();

            if (!game.GamersGames.Any(g => g.GamerId == userId))
            {
                game.GamersGames.Add(new GamerGame()
                {
                    GamerId = userId,
                    GameId = game.Id
                });

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(MyZone));
        }

        [HttpGet]
        public async Task<IActionResult> MyZone()
        {
            string userId = GetUserId();

            var model = await _context.GamersGames
                .Where(gg => gg.GamerId == userId)
                .AsNoTracking()
                .Select(gg => new GameInfoViewModel(
                    gg.GameId,
                    gg.Game.Title,
                    gg.Game.ReleasedOn,
                    gg.Game.Genre.Name,
                    gg.Game.ImageUrl,
                    gg.Game.Publisher.UserName
                ))
                .ToListAsync();

            return View(model);
        }

        public async Task<IActionResult> StrikeOut(int id)
        {
            var game = await _context.Games
                .Where(g => g.Id == id)
                .Include(g => g.GamersGames)
                .FirstOrDefaultAsync();

            if (game == null)
            {
                return BadRequest();
            }

            var userId = GetUserId();

            var gg = game.GamersGames.FirstOrDefault(gg => gg.GamerId == userId);

            if (gg == null)
            {
                return BadRequest();
            }

            game.GamersGames.Remove(gg);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(MyZone));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new GameFormViewModel();
            model.Genres = await GetGenres();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(GameFormViewModel model)
        {
            DateTime releasedOn = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                model.Genres = await GetGenres();

                return View(model);
            }

            var entity = new Game()
            {
                Title = model.Title,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                PublisherId = GetUserId(),
                ReleasedOn = releasedOn,
                GenreId = model.GenreId
            };

            await _context.Games.AddAsync(entity);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var game = await _context.Games
                .FindAsync(id);

            if (game == null)
            {
                return BadRequest();
            }

            if (game.PublisherId != GetUserId())
            {
                return Unauthorized();
            }

            var model = new GameFormViewModel()
            {
                Title = game.Title,
                ImageUrl = game.ImageUrl,
                Description = game.Description,
                GenreId = game.GenreId,
                ReleasedOn = game.ReleasedOn.ToString(),
            };

            model.Genres = await GetGenres();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(GameFormViewModel model, int id)
        {
            var game = await _context.Games
                .FindAsync(id);

            if (game == null)
            {
                return BadRequest();
            }

            if (game.PublisherId != GetUserId())
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                model.Genres = await GetGenres();

                return View(model);
            }

            game.Title = model.Title;
            game.Description = model.Description;
            game.ReleasedOn = DateTime.Parse(model.ReleasedOn);
            game.GenreId = model.GenreId;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var game = await _context.Games
                .Where(g => g.Id == id)
                .AsNoTracking()
                .Select(g => new DetailsViewModel()
                {
                    Id = g.Id,
                    ReleasedOn = g.ReleasedOn,
                    Genre = g.Genre.Name,
                    Description = g.Description,
                    ImageUrl = g.ImageUrl,
                    Title = g.Title,
                    Publisher = g.Publisher.UserName
                })
                .FirstOrDefaultAsync();

            if (game == null)
            {
                return BadRequest();
            }

            return View(game);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var game = await _context.Games
                .Where(g => g.Id == id)
                .AsNoTracking()
                .Select(g => new DetailsViewModel()
                {
                    Id = g.Id,
                    Title = g.Title,
                    Publisher = g.Publisher.UserName
                }).FirstOrDefaultAsync();

            if (game == null)
            {
                return NotFound();
            }

            if (game.Publisher != User.Identity.Name)
            {
                return Unauthorized();
            }

            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games
                .FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            if (game.PublisherId != GetUserId())
            {
                return Unauthorized();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        private async Task<ICollection<GenreViewModel>> GetGenres()
        {
            return await _context.Genres
                .AsNoTracking()
                .Select(g => new GenreViewModel
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToListAsync();
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
