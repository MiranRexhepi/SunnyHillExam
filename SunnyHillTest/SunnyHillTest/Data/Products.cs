using Microsoft.EntityFrameworkCore;
using SunnyHillTest.Models.products;

namespace SunnyHillTest.Data
{
    public class Products : DbContext
    {
        public Products(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProductsModel> ProductsOrdered { get; set; }
    }
}
