using System.Security.Cryptography;
using CDJ_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDJ_API.Data.Mappings;

public class CustumerMap : IEntityTypeConfiguration<Custumer>{
    public void Configure(EntityTypeBuilder<Custumer> builder)
    {
        builder.ToTable("cdj-custumer");

        builder.HasKey(x=>x.Id);

        builder.Property(x=>x.Id)
            .HasColumnName("id")
            .UseIdentityColumn()
            .ValueGeneratedOnAdd();

        builder.Property(x=>x.FirstName)
            .HasColumnName("first-name")
            .HasMaxLength(50)
            .HasColumnType("VARCHAR");
        
        builder.Property(x=>x.LastName)
            .HasColumnName("last-name")
            .HasMaxLength(60)
            .HasColumnType("VARCHAR");

        builder.Property(x=>x.PhoneNumber)
            .HasColumnName("phone-number")
            .HasMaxLength(11)
            .HasColumnType("VARCHAR"); 
        
        builder.Property(x=>x.BirthdayDate)
            .HasColumnName("birthday-date")
            .HasMaxLength(100)
            .HasColumnType("DATE");
    }
}