using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NETRazorCodeFirst.Data;
using NETRazorCodeFirst.Models;

namespace NETRazorCodeFirst.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid) {
                Product.DateCreated = DateTime.Now;

                _context.Product.Add(Product);
                await _context.SaveChangesAsync();
                Message = "Product added successfully!";
                return RedirectToPage("./Index");
            } else {
                return Page();
            }
        }
    }
}
