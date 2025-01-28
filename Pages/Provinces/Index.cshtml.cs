using CommunityApp.Data;
using CommunityApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Pages_Provinces
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Province> Province { get; set; } = new List<Province>();

        public async Task OnGetAsync()
        {
            Province = await _context.Provinces
                .Include(p => p.Cities) 
                .ToListAsync();
        }
    }
}
