using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASp.Net_WebDemo.Models;

namespace ASp.Net_WebDemo.Pages.Moives
{
    public class IndexModel : PageModel
    {
        private readonly ASp.Net_WebDemo.Models.MovieContext _context;

        public IndexModel(ASp.Net_WebDemo.Models.MovieContext context)
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
