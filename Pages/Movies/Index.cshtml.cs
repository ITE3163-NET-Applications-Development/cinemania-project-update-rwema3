using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CineMania.Data;
using CineMania.Models;

namespace CineMania.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly CineMania.Data.CinemaniaContext _context;

        public IndexModel(CineMania.Data.CinemaniaContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
