using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    
    public class MoviesListsController : Controller
    {
        private readonly TutorialContext _context;

        public MoviesListsController(TutorialContext context)
        {
            _context = context;
        }

        // GET: MoviesLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoviesList.ToListAsync());
        }

        // GET: MoviesLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moviesList = await _context.MoviesList
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (moviesList == null)
            {
                return NotFound();
            }

            return View(moviesList);
        }

        // GET: MoviesLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MoviesLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserID,Movies")] MoviesList moviesList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moviesList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moviesList);
        }

        // GET: MoviesLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moviesList = await _context.MoviesList.FindAsync(id);
            if (moviesList == null)
            {
                return NotFound();
            }
            return View(moviesList);
        }

        // POST: MoviesLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserID,Movies")] MoviesList moviesList)
        {
            if (id != moviesList.UserID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moviesList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoviesListExists(moviesList.UserID))
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
            return View(moviesList);
        }

        // GET: MoviesLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moviesList = await _context.MoviesList
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (moviesList == null)
            {
                return NotFound();
            }

            return View(moviesList);
        }

        // POST: MoviesLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moviesList = await _context.MoviesList.FindAsync(id);
            _context.MoviesList.Remove(moviesList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoviesListExists(string id)
        {
            return _context.MoviesList.Any(e => e.UserID == id);
        }
    }
}
