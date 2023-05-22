using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Learn_CSharp_EFCore_PointOfSaleSystem.Models.Db;

public partial class LearnCsharpEfcorePointOfSaleSystemDbContext : DbContext
{
    public LearnCsharpEfcorePointOfSaleSystemDbContext()
    {
    }

    public LearnCsharpEfcorePointOfSaleSystemDbContext(DbContextOptions<LearnCsharpEfcorePointOfSaleSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=localhost;Database=Learn_CSharp_EFCore_Beginner_DB;User ID=sa;Password=root;TrustServerCertificate=true;");

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => new { e.ProductId, e.ProductBarcode, e.ProductName, e.CategoryName, e.UnitName, e.Note }, "IX_Search");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CostPrice).HasColumnType("money");
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.ProductBarcode).HasMaxLength(15);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.SellingPrice).HasColumnType("money");
            entity.Property(e => e.UnitName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
