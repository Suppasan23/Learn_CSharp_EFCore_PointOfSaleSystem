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

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleDetail> SaleDetails { get; set; }

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
            entity.HasIndex(e => new { e.ProductId, e.ProductBarcode, e.ProductName, e.CategoryName, e.UnitName, e.Note }, "IX_Search").IsUnique();

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CostPrice).HasColumnType("money");
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.ProductBarcode).HasMaxLength(15);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.SellingPrice).HasColumnType("money");
            entity.Property(e => e.UnitName).HasMaxLength(50);
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => new { e.AutoId, e.SaleId });

            entity.HasIndex(e => e.SaleId, "IX_SalesID").IsUnique();

            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.SaleId)
                .HasMaxLength(20)
                .HasColumnName("SaleID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.SaleChange).HasColumnType("money");
            entity.Property(e => e.SaleDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SaleReceive).HasColumnType("money");
            entity.Property(e => e.SaleTotal).HasColumnType("money");
        });

        modelBuilder.Entity<SaleDetail>(entity =>
        {
            entity.HasKey(e => e.AutoId).HasName("PK_SaleDetail");

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductPrice).HasColumnType("money");
            entity.Property(e => e.SaleId)
                .HasMaxLength(20)
                .HasColumnName("SaleID");
            entity.Property(e => e.SubTotal).HasColumnType("money");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_SaleDetails_Products1");

            entity.HasOne(d => d.Sale).WithMany(p => p.SaleDetails)
                .HasPrincipalKey(p => p.SaleId)
                .HasForeignKey(d => d.SaleId)
                .HasConstraintName("FK_SaleDetails_Sales");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
