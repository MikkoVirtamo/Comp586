using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{   [EnableCors]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        TutorialContext context;
        public MoviesController(TutorialContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> getMovieByName(String name)
        {
           


            var _context = context;
            

            var query = _context.Movies
                      .Where(Movies => Movies.Title == name);
            



            return Ok(_context.Movies.Find(name));
        }

        [HttpGet]
        public async Task<IActionResult> getAllMovies()
        {



            var _context = context;


            
                   




            return Ok(_context.Movies.ToList());
        }
    }
}
