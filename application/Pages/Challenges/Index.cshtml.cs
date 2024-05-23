using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using application.Data;
using application.Models;

namespace application.Pages.Challenges
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Challenge> Challenges { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var challenges = from c in _context.Challenges
                             select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                challenges = challenges.Where(s => s.Title.Contains(SearchString));
            }

            Challenges = await challenges.ToListAsync();
        }
    }
}