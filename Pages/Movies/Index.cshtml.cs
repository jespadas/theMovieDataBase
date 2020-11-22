using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheMovieDataBase.Data;
using TheMovieDataBase.Models;

namespace TheMovieDataBase.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly TheMovieDataBase.Data.TheMovieDataBaseContext _context;

        public IndexModel(TheMovieDataBase.Data.TheMovieDataBaseContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
