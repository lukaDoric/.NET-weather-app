namespace back.Data
{
    using back.Models;
    // Data/AppDbContext.cs
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Weather> Weathers { get; set; }
    }

}
