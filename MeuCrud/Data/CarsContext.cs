using MeuCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuCrud.Data {
    public class CarsContext : DbContext {

        protected readonly IConfiguration _configuration;

        public CarsContext(IConfiguration configuration) {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Car> Cars { get; set; }
    }
}
