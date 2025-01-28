using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Data;
using CommunityApp.Models;

namespace CommunityApp.Pages_Provinces
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Province Province { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string? code) // 'id'를 'code'로 변경
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return NotFound();
            }

            Province = await _context.Provinces
                .Include(p => p.Cities)
                .FirstOrDefaultAsync(m => m.ProvinceCode == code);

            if (Province == null)
            {
                return NotFound();
            }

            Province.Cities ??= new List<City>();

            return Page();
        }
    }
}
