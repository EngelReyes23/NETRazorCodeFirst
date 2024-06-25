using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NETRazorCodeFirst.Data;
using NETRazorCodeFirst.Models;

namespace NETRazorCodeFirst.Pages.Products
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products { get; set; }

        public async Task OnGet()
        {
            Products = await _context.Product.ToListAsync();
        }
    }
}
