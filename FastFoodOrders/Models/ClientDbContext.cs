using Microsoft.EntityFrameworkCore;

namespace FastFoodOrders.Models
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Food> Foods { get; set; }

        public ClientDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
