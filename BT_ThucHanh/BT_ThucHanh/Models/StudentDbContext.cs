using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BT_ThucHanh.Models;

public partial class StudentDbContext : DbContext
{
    public StudentDbContext()
    {
    }

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KetQua> KetQuas { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Mon> Mons { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-CQIPA1K\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KetQua>(entity =>
        {
            entity.HasKey(e => new { e.MaSo, e.MaMh }).HasName("PK__KetQua__A5575580A24268DB");

            entity.ToTable("KetQua");

            entity.Property(e => e.MaMh)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("MaMH");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQua__MaMH__52593CB8");

            entity.HasOne(d => d.MaSoNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaSo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQua__MaSo__5165187F");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.Makhoa).HasName("PK__KHOA__5E7F13839CC96A16");

            entity.ToTable("KHOA");

            entity.Property(e => e.Makhoa)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Tenkhoa)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Mon>(entity =>
        {
            entity.HasKey(e => e.MaMh).HasName("PK__Mon__2725DFD97D6E654F");

            entity.ToTable("Mon");

            entity.Property(e => e.MaMh)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("MaMH");
            entity.Property(e => e.TenMh)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("TenMH");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSo).HasName("PK__SinhVien__2725087D435ABF92");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSo).ValueGeneratedNever();
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.Makhoa)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");

            entity.HasOne(d => d.MakhoaNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.Makhoa)
                .HasConstraintName("FK__SinhVien__Makhoa__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
