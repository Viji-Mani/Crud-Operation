using Crud_Operation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    }
}
