using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UchetZayavok.Database
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // Other DI initializations

            services.AddDbContext<AppDbContext>(options =>
                    options.UseNpgsql(System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
