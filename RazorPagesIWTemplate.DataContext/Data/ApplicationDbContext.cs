using Microsoft.EntityFrameworkCore;
using RazorPagesIWTemplate.Data;
namespace RazorPagesIWTemplate.DataContext.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public int Save()
        {
            return base.SaveChanges();
        }
    }
}
