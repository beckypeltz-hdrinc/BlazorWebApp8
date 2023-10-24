using BlazorWebApp8.Entity;
using Microsoft.EntityFrameworkCore;
namespace BlazorWebApp8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Game> Games { get; set; }
    }
}
