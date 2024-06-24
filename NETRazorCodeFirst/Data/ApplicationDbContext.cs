using Microsoft.EntityFrameworkCore;

namespace NETRazorCodeFirst.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}
