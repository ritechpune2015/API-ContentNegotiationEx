using Microsoft.EntityFrameworkCore;

namespace ContentNegotiationEx.Models
{
    public class CompanyContext:DbContext
    {

        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     ProductID = 1,
                     ProductName = "Mouse",
                     MfgName = "Intex",
                     Price = 450
                 }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     ProductID = 2,
                     ProductName = "Keyboard",
                     MfgName = "Logitech",
                     Price = 1450
                 }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     ProductID =3,
                     ProductName = "Monitor",
                     MfgName = "LG",
                     Price = 45000
                 }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     ProductID = 4,
                     ProductName = "MotherBoard",
                     MfgName = "Asus",
                     Price = 48000
                 }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     ProductID = 5,
                     ProductName = "SMPS",
                     MfgName = "Intex",
                     Price = 3500
                 }
                );
        }
        public DbSet<Product>   Products { get; set; }

    }
}
