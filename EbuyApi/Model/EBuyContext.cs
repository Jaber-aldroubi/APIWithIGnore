using Microsoft.EntityFrameworkCore;

namespace EbuyApi.Model
{
    public class EBuyContext : DbContext
    {

        public EBuyContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}