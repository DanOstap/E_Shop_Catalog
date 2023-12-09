using Microsoft.EntityFrameworkCore;
using E_Shop_Catalog.Model;

namespace E_Shop_Catalog.Database
{

    public class DataBaseContext : DbContext
    {

        public DbSet<ProductModel> Product { get; set; }
        public DbSet<LaptopModel> Laptops { get; set; }
        public DbSet<ComputerModel> Computers { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProductModel>().HasKey("Product_Id");
            builder.Entity<LaptopModel>().HasKey("Laptops_Id");
            builder.Entity<ComputerModel>().HasKey("Computers_Id");
        }
    }
}
