using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeminarHub.Data;
using SeminarHub.Models;
using System.Collections.Immutable;
using System.Security.Claims;

namespace SeminarHub.Controllers
{
    public class SeminarController : Controller
    {
        public readonly SeminarHubDbContext _context;

        public SeminarController(SeminarHubDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var seminars = await _context.Seminars
                .Select(s => new SeminarInfoViewModel(
                    s.Id,
                    s.Topic,
                    s.Lecturer,
                    s.Category.Name,
                    s.Organizer.UserName,
                    s.DateAndTime
                ))
                .ToListAsync();

            return View(seminars);
        }

        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            var seminar = await _context.Seminars
                .Where(s => s.Id == id)
                .Include(s => s.SeminarsParticipants)
                .FirstOrDefaultAsync();

            if (seminar == null)
            {
                return NotFound();
            }

            string userId = GetUserId();

            if (!seminar.SeminarsParticipants.Any(s => s.ParticipantId == userId))
            {
                seminar.SeminarsParticipants.Add(new SeminarParticipant()
                {
                    ParticipantId = userId,
                    SeminarId = seminar.Id
                });

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Joined));
        }

        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            string userId = GetUserId();

            var model = await _context.SeminarsParticipants
                .Where(sp => sp.ParticipantId == userId)
                .AsNoTracking()
                .Select(sp => new SeminarInfoViewModel(
                    sp.SeminarId,
                    sp.Seminar.Topic,
                    sp.Seminar.Lecturer,
                    sp.Seminar.Category.Name,
                    sp.Seminar.Organizer.UserName,
                    sp.Seminar.DateAndTime
                ))
                .ToListAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            var seminar = await _context.Seminars
                .Where(s => s.Id == id)
                .Include(s => s.SeminarsParticipants)
                .FirstOrDefaultAsync();

            if (seminar == null)
            {
                return NotFound();
            }

            var userId = GetUserId();

            var sp = seminar.SeminarsParticipants.FirstOrDefault(sp => sp.ParticipantId == userId);

            if (sp == null)
            {
                return BadRequest();
            }

            seminar.SeminarsParticipants.Remove(sp);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Joined));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new SeminarFormViewModel();
            model.Categories = await GetCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SeminarFormViewModel model)
        {
            DateTime dateAndTime = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();

                return View(model);
            }

            var entity = new Seminar()
            {
                Topic = model.Topic,
                Lecturer = model.Lecturer,
                Details = model.Details,
                Duration = model.Duration,
                OrganizerId = GetUserId(),
                CategoryId = model.CategoryId,
                DateAndTime = dateAndTime,
            };

            await _context.Seminars.AddAsync(entity);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var seminar = await _context.Seminars
                .FindAsync(id);

            if (seminar == null)
            {
                return BadRequest();
            }

            if (seminar.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            var model = new SeminarFormViewModel()
            {
                Topic = seminar.Topic,
                Lecturer = seminar.Lecturer,
                Details = seminar.Details,
                Duration = seminar.Duration,
                CategoryId = seminar.CategoryId,
                DateAndTime = seminar.DateAndTime.ToString()
            };

            model.Categories = await GetCategories();

            return View(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(SeminarFormViewModel model, int id)
        {
            var seminar = await _context.Seminars
                .FindAsync(id);

            if (seminar == null)
            {
                return NotFound();
            }

            if (seminar.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();

                return View(model);
            }

            seminar.Topic = model.Topic;
            seminar.Details = model.Details;
            seminar.DateAndTime = DateTime.Parse(model.DateAndTime);
            seminar.Duration = model.Duration;
            seminar.Lecturer = model.Lecturer;
            seminar.CategoryId = model.CategoryId;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var seminar = await _context.Seminars
                .Where(s => s.Id == id)
                .AsNoTracking()
                .Select(s => new DetailsViewModel()
                {
                    Id = s.Id,
                    DateAndTime = s.DateAndTime,
                    Duration = s.Duration,
                    Details = s.Details,
                    Organizer = s.Organizer.UserName,
                    Lecturer = s.Lecturer,
                    Category = s.Category.Name
                }).FirstOrDefaultAsync();

            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            DateTime date = DateTime.UtcNow;

            var seminar = await _context.Seminars
                .Where(s => s.Id == id)
                .AsNoTracking()
                .Select(s => new DetailsViewModel()
                {
                    Id = s.Id,
                    Topic = s.Topic,
                    Organizer = s.Organizer.UserName,
                    DateAndTime = date
                }).FirstOrDefaultAsync();

            if (seminar == null)
            {
                return NotFound();
            }

            if (seminar.Organizer != User?.Identity?.Name)
            {
                return Unauthorized();
            }

            return View(seminar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seminar = await _context.Seminars
                .FindAsync(id);

            if (seminar == null)
            {
                return Unauthorized();
            }

            if (seminar.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            _context.Seminars.Remove(seminar);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        public async Task<ICollection<CategoryViewModel>> GetCategories()
        {
            return await _context.Categories
                .AsNoTracking()
                .Select(s => new CategoryViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                }).ToListAsync();
        }

        public string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
