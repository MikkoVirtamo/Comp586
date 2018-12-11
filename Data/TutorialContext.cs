using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class TutorialContext : DbContext
    {
        public TutorialContext(DbContextOptions<TutorialContext> options) : base(options)
        {
        }

        public DbSet<MoviesList> MoviesList { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Movies> Movies { get; set; }
    }
}
