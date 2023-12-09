using Microsoft.EntityFrameworkCore;
using E_Shop_Catalog.Model;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using E_Shop_Catalog.Migrations;

namespace E_Shop_Catalog.Service
{

    public class DataBaseContex : DbContext
    {
      
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<LaptopMdel> Laptops { get; set; }
        public DbSet<ComputerModel> Computers { get; set; }
        public DataBaseContex(DbContextOptions<DataBaseContex> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProductModel>().ToTable("Products"); 
            builder.Entity<LaptopMdel>().ToTable("Laptops"); 
            builder.Entity<ComputerModel>().ToTable("Computers"); 

        }




    }
}
