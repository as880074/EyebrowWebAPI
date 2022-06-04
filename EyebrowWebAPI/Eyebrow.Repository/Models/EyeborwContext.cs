using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Eyebrow.Repository.Models
{
    public partial class EyeborwContext : DbContext
    {
        public EyeborwContext()
        {
        }

        public EyeborwContext(DbContextOptions<EyeborwContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Announcement> Announcements { get; set; } = null!;
        public virtual DbSet<Banner> Banners { get; set; } = null!;
        public virtual DbSet<Portfolio> Portfolios { get; set; } = null!;
        public virtual DbSet<Reserve> Reserves { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;
        public virtual DbSet<SysCode> SysCodes { get; set; } = null!;
        public virtual DbSet<SysSetting> SysSettings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=database-1.ccaf4incidtw.ap-southeast-1.rds.amazonaws.com;port=3306;database=Eyebrow;user=admin;password=2ICVoYdf8ajNDtGa35Lr", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("Announcement");

                entity.Property(e => e.CreateTime).HasColumnName("Create_Time");

                entity.Property(e => e.ShelfTime).HasColumnName("Shelf_Time");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("Banner");

                entity.Property(e => e.BannerOrder).HasColumnName("Banner_Order");

                entity.Property(e => e.ImagePath).HasMaxLength(512);

                entity.Property(e => e.Url).HasMaxLength(512);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("Portfolio");

                entity.Property(e => e.AfterPath)
                    .HasMaxLength(512)
                    .HasColumnName("After_Path");

                entity.Property(e => e.BeforePath)
                    .HasMaxLength(512)
                    .HasColumnName("Before_Path");

                entity.Property(e => e.PortfolioName)
                    .HasMaxLength(255)
                    .HasColumnName("Portfolio_Name");

                entity.Property(e => e.PortfolioOrder).HasColumnName("Portfolio_Order");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategory_Id");
            });

            modelBuilder.Entity<Reserve>(entity =>
            {
                entity.ToTable("Reserve");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(3)
                    .HasColumnName("Category_Id");

                entity.Property(e => e.Period).HasColumnType("bit(1)");

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.ReserveName).HasMaxLength(16);

                entity.Property(e => e.SubCategoryId)
                    .HasMaxLength(3)
                    .HasColumnName("SubCategory_Id");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("SubCategory");

                entity.Property(e => e.CategoryId).HasMaxLength(3);

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("SubCategory_Name");

                entity.Property(e => e.SubCategoryOrder).HasColumnName("SubCategory_Order");
            });

            modelBuilder.Entity<SysCode>(entity =>
            {
                entity.ToTable("Sys_Code");

                entity.Property(e => e.ScCode)
                    .HasMaxLength(255)
                    .HasColumnName("SC_Code");

                entity.Property(e => e.ScDesc)
                    .HasMaxLength(255)
                    .HasColumnName("SC_Desc");

                entity.Property(e => e.ScOrder).HasColumnName("SC_Order");

                entity.Property(e => e.ScType)
                    .HasMaxLength(255)
                    .HasColumnName("SC_Type");
            });

            modelBuilder.Entity<SysSetting>(entity =>
            {
                entity.ToTable("Sys_Setting");

                entity.Property(e => e.SsDese)
                    .HasMaxLength(255)
                    .HasColumnName("SS_Dese");

                entity.Property(e => e.SsKey)
                    .HasMaxLength(255)
                    .HasColumnName("SS_Key");

                entity.Property(e => e.SsOrder).HasColumnName("SS_Order");

                entity.Property(e => e.SsType)
                    .HasMaxLength(255)
                    .HasColumnName("SS_Type");

                entity.Property(e => e.SsValue)
                    .HasMaxLength(1500)
                    .HasColumnName("SS_Value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
