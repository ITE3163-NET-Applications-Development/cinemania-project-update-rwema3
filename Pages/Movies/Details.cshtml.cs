using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CineMania.Data;
using CineMania.Models;

namespace CineMania.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly CineMania.Data.CinemaniaContext _context;

        public DetailsModel(CineMania.Data.CinemaniaContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }
        public IList<Movie> RelatedMovie { get; set; }
        //focus on this line too
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            
            
            //focus on this line downhere
            RelatedMovie = await _context.Movies.Where(m => m.Genre == Movie.Genre).
                Where(m => m.Id != Movie.Id).
                ToListAsync();
            if (Movie == null && RelatedMovie == null)
            {
                return NotFound();
            }
            
            return Page();
        }
        

    }
}
