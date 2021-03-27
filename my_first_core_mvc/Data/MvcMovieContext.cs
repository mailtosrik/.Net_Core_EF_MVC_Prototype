using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_first_core_mvc_movie.Models;

namespace my_first_core_mvc_movie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }
}
