using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BT_ThucHanh.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KetQua> KetQuas { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Mon> Mons { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=Student;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KetQua>(entity =>
        {
            entity.HasKey(e => new { e.MaSo, e.MaMh }).HasName("PK__KetQua__A557558072D17A17");

            entity.ToTable("KetQua");

            entity.Property(e => e.MaMh)
                .HasMaxLength(10)
                .HasColumnName("MaMH");
            entity.Property(e => e.Diem).HasColumnType("decimal(4, 2)");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KetQua_Mon");

            entity.HasOne(d => d.MaSoNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaSo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KetQua_SV");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.Makhoa).HasName("PK__KHOA__65390405CE5C71CA");

            entity.ToTable("KHOA");

            entity.Property(e => e.Makhoa).HasMaxLength(10);
            entity.Property(e => e.Tenkhoa).HasMaxLength(50);
        });

        modelBuilder.Entity<Mon>(entity =>
        {
            entity.HasKey(e => e.MaMh).HasName("PK__Mon__2725DFD990ECC86D");

            entity.ToTable("Mon");

            entity.Property(e => e.MaMh)
                .HasMaxLength(10)
                .HasColumnName("MaMH");
            entity.Property(e => e.TenMh)
                .HasMaxLength(50)
                .HasColumnName("TenMH");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSo).HasName("PK__SinhVien__2725087D9C9986C5");

            entity.ToTable("SinhVien");

            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh).HasDefaultValue(true);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.Makhoa).HasMaxLength(10);

            entity.HasOne(d => d.MakhoaNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.Makhoa)
                .HasConstraintName("FK_SinhVien_Khoa");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
