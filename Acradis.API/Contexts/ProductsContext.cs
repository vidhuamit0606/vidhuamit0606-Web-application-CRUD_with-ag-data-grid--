using Acradis.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acradis.API.Contexts
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductsContext(DbContextOptions<ProductsContext> options)
                   : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Title = "Backplate replacement, ABS Plastic Louver, 3 - Section",
                    Cost = 345.00m,
                    Quantity = 2
                },

                new Product()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Title = "Backplate replacement, ABS Plastic Louver, 4 - Section (FYA)",
                    Cost = 450.00m,
                    Quantity = 12
                },
                new Product()
                {
                    Id = Guid.Parse("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                    Title = "Backplate replacement, ABS Plastic Louver, 4 - Section (T-shaped protected only)",
                    Cost = 500.00m,
                    Quantity = 8
                },
                new Product()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Title = "Backplate replacement, ABS Plastic Louver, 5 - Section",
                    Cost = 20.00m,
                    Quantity = 48
                }


                );
            base.OnModelCreating(modelBuilder);


        }
        

        }
}
