using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject;

public partial class JewelleryOrderContext : DbContext
{
    public JewelleryOrderContext()
    {
    }

    public JewelleryOrderContext(DbContextOptions<JewelleryOrderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Design> Designs { get; set; }

    public virtual DbSet<Have> Haves { get; set; }

    public virtual DbSet<MasterGemstone> MasterGemstones { get; set; }

    public virtual DbSet<MaterialDTO> Materials { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Requirement> Requirements { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Stone> Stones { get; set; }

    public virtual DbSet<TypeOfJewelry> TypeOfJewelries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WarrantyCard> WarrantyCards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI;uid=sa;pwd=12345;database=JewelleryOrder;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.BlogId).HasName("PK__Blog__54379E50405C1070");

            entity.ToTable("Blog");

            entity.Property(e => e.BlogId)
                .ValueGeneratedNever()
                .HasColumnName("BlogID");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.Manager).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__Blog__ManagerID__3C69FB99");
        });

        modelBuilder.Entity<Design>(entity =>
        {
            entity.HasKey(e => e.DesignId).HasName("PK__Design__32B8E17F925EE929");

            entity.ToTable("Design");

            entity.Property(e => e.DesignId)
                .ValueGeneratedNever()
                .HasColumnName("DesignID");
            entity.Property(e => e.DesignName).HasMaxLength(255);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.MasterGemstoneId).HasColumnName("MasterGemstoneID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.StonesId).HasColumnName("StonesID");
            entity.Property(e => e.TypeOfJewelryId).HasColumnName("TypeOfJewelryID");
            entity.Property(e => e.WeightOfMaterial).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Manager).WithMany(p => p.Designs)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__Design__ManagerI__49C3F6B7");

            entity.HasOne(d => d.MasterGemstone).WithMany(p => p.Designs)
                .HasForeignKey(d => d.MasterGemstoneId)
                .HasConstraintName("FK__Design__MasterGe__48CFD27E");

            entity.HasOne(d => d.Material).WithMany(p => p.Designs)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK__Design__Material__4BAC3F29");

            entity.HasOne(d => d.Stones).WithMany(p => p.Designs)
                .HasForeignKey(d => d.StonesId)
                .HasConstraintName("FK__Design__StonesID__47DBAE45");

            entity.HasOne(d => d.TypeOfJewelry).WithMany(p => p.Designs)
                .HasForeignKey(d => d.TypeOfJewelryId)
                .HasConstraintName("FK__Design__TypeOfJe__4AB81AF0");
        });

        modelBuilder.Entity<Have>(entity =>
        {
            entity.HasKey(e => new { e.WarrantyCardId, e.RequirementsId }).HasName("PK__Have__70941506191BF561");

            entity.ToTable("Have");

            entity.Property(e => e.WarrantyCardId).HasColumnName("WarrantyCardID");
            entity.Property(e => e.RequirementsId).HasColumnName("RequirementsID");

            entity.HasOne(d => d.Requirements).WithMany(p => p.Haves)
                .HasForeignKey(d => d.RequirementsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Have__Requiremen__571DF1D5");

            entity.HasOne(d => d.WarrantyCard).WithMany(p => p.Haves)
                .HasForeignKey(d => d.WarrantyCardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Have__WarrantyCa__5629CD9C");
        });

        modelBuilder.Entity<MasterGemstone>(entity =>
        {
            entity.HasKey(e => e.MasterGemstoneId).HasName("PK__MasterGe__D4657CE30CC26B2A");

            entity.ToTable("MasterGemstone");

            entity.Property(e => e.MasterGemstoneId)
                .ValueGeneratedNever()
                .HasColumnName("MasterGemstoneID");
            entity.Property(e => e.Kind).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Size).HasMaxLength(50);
        });

        modelBuilder.Entity<MaterialDTO>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PK__Material__C5061317F3CCF67C");

            entity.ToTable("Material");

            entity.Property(e => e.MaterialId)
                .ValueGeneratedNever()
                .HasColumnName("MaterialID");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Manager).WithMany(p => p.Materials)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__Material__Manage__3F466844");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A587F02373E");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Method).HasMaxLength(255);
            entity.Property(e => e.RequirementsId).HasColumnName("RequirementsID");

            entity.HasOne(d => d.Requirements).WithMany(p => p.Payments)
                .HasForeignKey(d => d.RequirementsId)
                .HasConstraintName("FK__Payment__Require__5165187F");
        });

        modelBuilder.Entity<Requirement>(entity =>
        {
            entity.HasKey(e => e.RequirementsId).HasName("PK__Requirem__CA9962C54FF07A87");

            entity.Property(e => e.RequirementsId)
                .ValueGeneratedNever()
                .HasColumnName("RequirementsID");
            entity.Property(e => e.DesignId).HasColumnName("DesignID");
            entity.Property(e => e.GoldPriceAtMoment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MatchingFee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.StonePriceAtMoment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoney).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Design).WithMany(p => p.Requirements)
                .HasForeignKey(d => d.DesignId)
                .HasConstraintName("FK__Requireme__Desig__4E88ABD4");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A3D73B2D2");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Stone>(entity =>
        {
            entity.HasKey(e => e.StonesId).HasName("PK__Stones__79EF191EB73F094D");

            entity.Property(e => e.StonesId)
                .ValueGeneratedNever()
                .HasColumnName("StonesID");
            entity.Property(e => e.Kind).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Size).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeOfJewelry>(entity =>
        {
            entity.HasKey(e => e.TypeOfJewelryId).HasName("PK__TypeOfJe__D2871F6B8A3D8C61");

            entity.ToTable("TypeOfJewelry");

            entity.Property(e => e.TypeOfJewelryId)
                .ValueGeneratedNever()
                .HasColumnName("TypeOfJewelryID");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UsersId).HasName("PK__Users__A349B0428A62A4EA");

            entity.Property(e => e.UsersId)
                .ValueGeneratedNever()
                .HasColumnName("UsersID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleID__398D8EEE");

            entity.HasMany(d => d.Requirements).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersRequirement",
                    r => r.HasOne<Requirement>().WithMany()
                        .HasForeignKey("RequirementsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UsersRequ__Requi__5AEE82B9"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UsersRequ__Users__59FA5E80"),
                    j =>
                    {
                        j.HasKey("UsersId", "RequirementsId").HasName("PK__UsersReq__EFE0266EF1100516");
                        j.ToTable("UsersRequirements");
                        j.IndexerProperty<int>("UsersId").HasColumnName("UsersID");
                        j.IndexerProperty<int>("RequirementsId").HasColumnName("RequirementsID");
                    });
        });

        modelBuilder.Entity<WarrantyCard>(entity =>
        {
            entity.HasKey(e => e.WarrantyCardId).HasName("PK__Warranty__3C3D832A5A7019CD");

            entity.ToTable("WarrantyCard");

            entity.Property(e => e.WarrantyCardId)
                .ValueGeneratedNever()
                .HasColumnName("WarrantyCardID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
