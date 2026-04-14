using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PezPez.Infrastructure.Persistence.Entities;

namespace PezPez.Infrastructure.Persistence.Contexts;

public partial class PezPezDbContext : DbContext
{
    public PezPezDbContext(DbContextOptions<PezPezDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC07E14D8C9E");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
