using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WPFQLVeXe.Models;

public partial class BanVeEntities : DbContext
{
    public BanVeEntities()
    {
    }

    public BanVeEntities(DbContextOptions<BanVeEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Ghe> Ghes { get; set; }

    public virtual DbSet<HangHoa> HangHoas { get; set; }

    public virtual DbSet<HinhThuc> HinhThucs { get; set; }

    public virtual DbSet<HoaDonHh> HoaDonHhs { get; set; }

    public virtual DbSet<HoaDonVe> HoaDonVes { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LichTrinh> LichTrinhs { get; set; }

    public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }

    public virtual DbSet<LoaiTk> LoaiTks { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhanCong> PhanCongs { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TuyenXe> TuyenXes { get; set; }

    public virtual DbSet<VeXe> VeXes { get; set; }

    public virtual DbSet<XeKhach> XeKhaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);Database=quanlibanve;Uid=sa;Pwd=admin;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ghe>(entity =>
        {
            entity.HasKey(e => e.MaGhe);

            entity.ToTable("Ghe");

            entity.Property(e => e.MaGhe)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaTuyen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SoXe)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TinhTrang).HasMaxLength(50);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Ghes)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_Ghe_KhachHang");

            entity.HasOne(d => d.MaTuyenNavigation).WithMany(p => p.Ghes)
                .HasForeignKey(d => d.MaTuyen)
                .HasConstraintName("FK_Ghe_TuyenXe");
        });

        modelBuilder.Entity<HangHoa>(entity =>
        {
            entity.HasKey(e => e.MaHh);

            entity.ToTable("HangHoa");

            entity.Property(e => e.MaHh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHH");
            entity.Property(e => e.LoaiHh)
                .HasMaxLength(10)
                .HasColumnName("LoaiHH");
            entity.Property(e => e.NguoiGui)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NguoiNhan)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NhanVienNhan)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.NhanVienNhanNavigation).WithMany(p => p.HangHoas)
                .HasForeignKey(d => d.NhanVienNhan)
                .HasConstraintName("FK_HangHoa_NhanVien");
        });

        modelBuilder.Entity<HinhThuc>(entity =>
        {
            entity.HasKey(e => e.LoaiHt);

            entity.ToTable("HinhThuc");

            entity.Property(e => e.LoaiHt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LoaiHT");
            entity.Property(e => e.TenHt)
                .HasMaxLength(50)
                .HasColumnName("TenHT");
        });

        modelBuilder.Entity<HoaDonHh>(entity =>
        {
            entity.HasKey(e => e.MaHd);

            entity.ToTable("HoaDonHH");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaHh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHH");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaKH");

            entity.HasOne(d => d.MaHhNavigation).WithMany(p => p.HoaDonHhs)
                .HasForeignKey(d => d.MaHh)
                .HasConstraintName("FK_HoaDonHH_HangHoa");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDonHhs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_HoaDonHH_KhachHang");
        });

        modelBuilder.Entity<HoaDonVe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HoaDonVe");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaVe)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.MaKhNavigation).WithMany()
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_HoaDonVe_KhachHang");

            entity.HasOne(d => d.MaVeNavigation).WithMany()
                .HasForeignKey(d => d.MaVe)
                .HasConstraintName("FK_HoaDonVe_VeXe");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh);

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaKH");
            entity.Property(e => e.Cmnd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CMND");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.HinhThuc)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");

            entity.HasOne(d => d.HinhThucNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.HinhThuc)
                .HasConstraintName("FK_KhachHang_HinhThuc");
        });

        modelBuilder.Entity<LichTrinh>(entity =>
        {
            entity.HasKey(e => new { e.MaTuyen, e.NgayDi, e.NgayDen, e.SoXe });

            entity.ToTable("LichTrinh");

            entity.Property(e => e.MaTuyen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SoXe)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.MaTuyenNavigation).WithMany(p => p.LichTrinhs)
                .HasForeignKey(d => d.MaTuyen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichTrinh_TuyenXe2");

            entity.HasOne(d => d.SoXeNavigation).WithMany(p => p.LichTrinhs)
                .HasForeignKey(d => d.SoXe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichTrinh_XeKhach");
        });

        modelBuilder.Entity<LoaiNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaLoaiNv);

            entity.ToTable("LoaiNhanVien");

            entity.Property(e => e.MaLoaiNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLoaiNV");
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiTk>(entity =>
        {
            entity.HasKey(e => e.MaLoaiTk);

            entity.ToTable("LoaiTK");

            entity.Property(e => e.MaLoaiTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLoaiTK");
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaNV");
            entity.Property(e => e.BiXoa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cmnd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CMND");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.LoaiNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LoaiNV");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");

            entity.HasOne(d => d.LoaiNvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.LoaiNv)
                .HasConstraintName("FK_NhanVien_LoaiNhanVien");
        });

        modelBuilder.Entity<PhanCong>(entity =>
        {
            entity.HasKey(e => e.MaTuyen);

            entity.ToTable("PhanCong");

            entity.Property(e => e.MaTuyen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaNV");
            entity.Property(e => e.MaPx)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaPX");

            entity.HasOne(d => d.MaTuyenNavigation).WithOne(p => p.PhanCong)
                .HasForeignKey<PhanCong>(d => d.MaTuyen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhanCong_TuyenXe");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => new { e.TenDn, e.MatKhau });

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.TenDn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenDN");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LoaiTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LoaiTK");

            entity.HasOne(d => d.LoaiTkNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.LoaiTk)
                .HasConstraintName("FK_TaiKhoan_LoaiTK");
        });

        modelBuilder.Entity<TuyenXe>(entity =>
        {
            entity.HasKey(e => e.MaTuyen);

            entity.ToTable("TuyenXe");

            entity.Property(e => e.MaTuyen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaDiemDen).HasMaxLength(50);
            entity.Property(e => e.DiaDiemDi).HasMaxLength(50);
        });

        modelBuilder.Entity<VeXe>(entity =>
        {
            entity.HasKey(e => e.MaVe);

            entity.ToTable("VeXe");

            entity.Property(e => e.MaVe)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaGhe)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaKH");
            entity.Property(e => e.NhanVienBv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NhanVienBV");
            entity.Property(e => e.SoXe)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.NhanVienBvNavigation).WithMany(p => p.VeXes)
                .HasForeignKey(d => d.NhanVienBv)
                .HasConstraintName("FK_VeXe_NhanVien");

            entity.HasOne(d => d.SoXeNavigation).WithMany(p => p.VeXes)
                .HasForeignKey(d => d.SoXe)
                .HasConstraintName("FK_VeXe_XeKhach");
        });

        modelBuilder.Entity<XeKhach>(entity =>
        {
            entity.HasKey(e => e.SoXe);

            entity.ToTable("XeKhach");

            entity.Property(e => e.SoXe)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.HangSx)
                .HasMaxLength(50)
                .HasColumnName("HangSX");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
