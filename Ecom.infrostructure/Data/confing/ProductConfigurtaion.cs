using Ecom.Core.Enities.product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.infrostructure.Data.confing
{
    public class ProductConfigurtaion : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.HasData(
                new Product { Id = 1, Name = "Smartphone", Description = "Latest smartphone with advanced features", Price = 699.99m, categoryId = 1 },
                new Product { Id = 2, Name = "Laptop", Description = "High-performance laptop for work and gaming", Price = 1299.99m, categoryId = 1 },
                new Product { Id = 3, Name = "T-Shirt", Description = "Comfortable cotton t-shirt in various colors", Price = 19.99m, categoryId = 2 },
                new Product { Id = 4, Name = "Jeans", Description = "Stylish denim jeans for casual wear", Price = 49.99m, categoryId = 2 },
                new Product { Id = 5, Name = "Novel", Description = "Bestselling fiction novel by a renowned author", Price = 14.99m, categoryId = 3 },
                new Product { Id = 6, Name = "Cookbook", Description = "Collection of delicious recipes for home cooking", Price = 24.99m, categoryId = 3 }
            );
        }
    }
}
