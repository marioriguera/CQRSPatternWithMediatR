using Domain.Entities;
using Infraestructure.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configurations
{
    internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(TableNames.Products);

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .HasColumnName(nameof(Product.Id))
                .HasColumnType("uniqueidentifier")
                .HasColumnOrder(0)
                .ValueGeneratedNever();

            builder.Property(p => p.Name)
                .HasColumnName(nameof(Product.Name))
                .HasColumnType("nvarchar(100)")
                .HasColumnOrder(10)
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnName(nameof(Product.Price))
                .HasColumnType("decimal(18,2)")
                .HasPrecision(18, 2)
                .HasColumnOrder(20)
                .IsRequired();

            builder.HasData(
                    new Product { Id = Guid.NewGuid(), Name = "Potato", Price = 1.05m },
                    new Product { Id = Guid.NewGuid(), Name = "Coca Cola", Price = 2.10m },
                    new Product { Id = Guid.NewGuid(), Name = "Onion", Price = 0.50m },
                    new Product { Id = Guid.NewGuid(), Name = "Bread", Price = 0.80m },
                    new Product { Id = Guid.NewGuid(), Name = "Meat", Price = 4.15m },
                    new Product { Id = Guid.NewGuid(), Name = "Rice", Price = 1.00m }
                );
        }
    }
}
