using Microsoft.EntityFrameworkCore;
using SampleAPI.Models.Entities;

namespace SampleAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> students;
    }
}
