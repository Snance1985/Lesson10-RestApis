using l10_assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace l10_assignment.Migrations;

public class PetDbContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }
    public PetDbContext(DbContextOptions<PetDbContext> options)
        : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId);
            entity.Property(e => e.PetName).IsRequired();
            entity.Property(e => e.Type).IsRequired();
            entity.Property(e => e.Description).IsRequired();
        });
    }
}