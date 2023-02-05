using Microsoft.EntityFrameworkCore;

namespace MoneyExchangeAPI.Models
{
    public class MoneyExchangeDBContext : DbContext
    {
        public MoneyExchangeDBContext(DbContextOptions options):base(options) { }

        public DbSet<Users> User { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<City> City { get; set; }


    }
}
