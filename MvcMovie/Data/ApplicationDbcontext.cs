using Microsoft.EntilyFrameWorkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbcontext : DbContext
{
    public ApplicationDbcontext(DbcontextOptions<ApplicationDbcontext> options) : base(options)
{}
    public DbSet<Person> Person { get; set;}
}
}