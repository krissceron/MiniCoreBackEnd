using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MinicoreCompras.Models;

namespace MinicoreCompras.Models;

public partial class MiniCoreVentasContext : DbContext
{
    public MiniCoreVentasContext()
    {
    }

    public MiniCoreVentasContext(DbContextOptions<MiniCoreVentasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Vendedor> Vendedores { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.HasKey(e => e.IdVendedor).HasName("vendedores");

            entity.ToTable("vendedores");

            entity.Property(e => e.IdVendedor).HasColumnName("idVendedor");
            entity.Property(e => e.NombreVendedor)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__Venta__91431FE1C0001ED1");

            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.Ventas)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("ventas");
            entity.Property(e => e.FechaVenta)
                .HasColumnType("date")
                .HasColumnName("fechaVenta");
            entity.Property(e => e.IdVendedor).HasColumnName("idVendedor");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Ventas)
                .HasForeignKey(d => d.IdVendedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

