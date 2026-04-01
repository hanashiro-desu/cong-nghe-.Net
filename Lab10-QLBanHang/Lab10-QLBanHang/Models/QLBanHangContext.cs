using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab10_QLBanHang.Models;

public partial class QLBanHangContext : DbContext
{
    public QLBanHangContext()
    {
    }

    public QLBanHangContext(DbContextOptions<QLBanHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chitietdh> Chitietdhs { get; set; }

    public virtual DbSet<Donhang> Donhangs { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=QLBanHang;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chitietdh>(entity =>
        {
            entity.HasKey(e => e.MaCt).HasName("PK__CHITIETD__27258E744B84E2A7");

            entity.ToTable("CHITIETDH");

            entity.Property(e => e.MaCt).HasColumnName("MaCT");
            entity.Property(e => e.MaDh).HasColumnName("MaDH");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.SoLuong).HasDefaultValue(1);

            entity.HasOne(d => d.MaDhNavigation).WithMany(p => p.Chitietdhs)
                .HasForeignKey(d => d.MaDh)
                .HasConstraintName("FK__CHITIETDH__MaDH__5629CD9C");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.Chitietdhs)
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__CHITIETDH__MaSP__571DF1D5");
        });

        modelBuilder.Entity<Donhang>(entity =>
        {
            entity.HasKey(e => e.MaDh).HasName("PK__DONHANG__272586613CE1BE47");

            entity.ToTable("DONHANG");

            entity.Property(e => e.MaDh).HasColumnName("MaDH");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.NgayDat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(20)
                .HasDefaultValue("ChuaXuLy");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__DONHANG__MaKH__534D60F1");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KHACHHAN__2725CF1EFA49421A");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(60);
            entity.Property(e => e.NgayDangKy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SANPHAM__2725081CB033A9E7");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.DanhMuc).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
