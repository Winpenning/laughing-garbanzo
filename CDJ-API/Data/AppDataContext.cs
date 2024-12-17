using CDJ_API.Data.Mappings;
using CDJ_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CDJ_API.Data;

public class AppDataContext : DbContext{
    public AppDataContext(DbContextOptions<AppDataContext> opt): base(opt)
    {}
    public DbSet<Custumer> Custumers { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustumerMap());
        modelBuilder.ApplyConfiguration(new ProductMap());
    }
}