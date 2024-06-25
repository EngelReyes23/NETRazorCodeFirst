using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NETRazorCodeFirst.Data;
using NETRazorCodeFirst.Models;

namespace NETRazorCodeFirst.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task OnGet(int id)
        {
            Product = await _context.Product.FindAsync(id);
        }

        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid) {
                _context.Attach(Product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            } else {
                return Page();
            }
        }
    }
}
