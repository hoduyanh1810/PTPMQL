using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;  

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Person> Person { get; set; } 
    }
}



