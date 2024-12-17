using CDJ_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CDJ_API.Data.Mappings;
public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("cdj-produtos");

        builder.HasKey(x=>x.Id);
        
        builder.Property(x=>x.Id)
            .UseIdentityColumn()
            .HasColumnName("id")
            .UseIdentityColumn();
        
        builder.Property(x=>x.Name)
            .HasColumnName("product-name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.UnitType)
            .HasColumnName("unit-type")
            .HasColumnType("VARCHAR")
            .HasMaxLength(5);
        
        builder.Property(x=>x.UnitCount)
            .HasColumnName("unit-count")
            .HasColumnType("INT");
        
        builder.Property(x=>x.UnitPrice)
            .HasColumnName("unit-price")
            .HasColumnType("SMALLMONEY");
    }
}