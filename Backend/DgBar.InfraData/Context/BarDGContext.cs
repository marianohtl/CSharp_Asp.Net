using DgBar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgBar.InfraData.Context
{
    public partial class BarDGContext : DbContext
    {
        public BarDGContext()
        {
        }

        public BarDGContext(DbContextOptions<BarDGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<SheetOrder> SheetOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-758CUUA\\SQLEXPRESS;Initial Catalog=BarDG;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("MENU");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<SheetOrder>(entity =>
            {
                entity.ToTable("SHEET_ORDER");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdMenuNavigation)
                    .WithMany(p => p.SheetOrder)
                    .HasForeignKey(d => d.IdMenu)
                    .HasConstraintName("FK__SHEET_ORD__IdMen__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
