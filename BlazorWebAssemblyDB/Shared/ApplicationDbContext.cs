using BlazorWebAssemblyDB.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyDB.Shared
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
