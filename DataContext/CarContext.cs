using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarApp
{
    public class CarContext : DbContext
    {
        // public CarContext(DbContextOptions<CarContext> options) : base(options)
        // {
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(System.Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            optionsBuilder.UseSqlServer("Server=LAPTOP-UKT0QQ1K;Database=CarManagement;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Car> Cars { get; set; }
    }
}