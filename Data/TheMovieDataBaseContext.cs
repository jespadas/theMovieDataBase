using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheMovieDataBase.Models;

namespace TheMovieDataBase.Data
{
    public class TheMovieDataBaseContext : DbContext
    {
        public TheMovieDataBaseContext (DbContextOptions<TheMovieDataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<TheMovieDataBase.Models.Movie> Movie { get; set; }
    }
}
