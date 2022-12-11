using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatGiaoThucAn.Models;

public partial class HtdatGiaoThucAnContext : DbContext
{
    public HtdatGiaoThucAnContext()
    {
    }

    public HtdatGiaoThucAnContext(DbContextOptions<HtdatGiaoThucAnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<ChiTietGiaoHang> ChiTietGiaoHangs { get; set; }

    public virtual DbSet<CuaHangChiNhanh> CuaHangChiNhanhs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<HopDong> HopDongs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TaiXe> TaiXes { get; set; }

    public virtual DbSet<ThongTinDaiDien> ThongTinDaiDiens { get; set; }

    public virtual DbSet<ThongTinDoiTac> ThongTinDoiTacs { get; set; }

    public virtual DbSet<ThucDon> ThucDons { get; set; }

    public virtual DbSet<XacNhanHopDong> XacNhanHopDongs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HTDatGiaoThucAn;User ID=HT_AD;Password=admin;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => new { e.MaDonHang, e.MaMon }).HasName("PK__ChiTietD__8130363735BCFE0A");

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.MaDonHang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaMon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TuyChon).HasMaxLength(100);

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTDH_DH_MaDH");

            entity.HasOne(d => d.MaMonNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaMon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTDH_ThucDon");
        });

        modelBuilder.Entity<ChiTietGiaoHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK_TaiXe_GiaoHang");

            entity.ToTable("ChiTietGiaoHang");

            entity.Property(e => e.MaDonHang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaTx)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTX");
            entity.Property(e => e.TinhTrangGiaoHang).HasMaxLength(30);

            entity.HasOne(d => d.MaDonHangNavigation).WithOne(p => p.ChiTietGiaoHang)
                .HasForeignKey<ChiTietGiaoHang>(d => d.MaDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TXGH_DH");

            entity.HasOne(d => d.MaTxNavigation).WithMany(p => p.ChiTietGiaoHangs)
                .HasForeignKey(d => d.MaTx)
                .HasConstraintName("FK_TXGH_TX");
        });

        modelBuilder.Entity<CuaHangChiNhanh>(entity =>
        {
            entity.HasKey(e => new { e.ChiNhanh, e.CuaHang }).HasName("PK__CuaHang___8461CEF422AA2996");

            entity.ToTable("CuaHang_ChiNhanh");

            entity.Property(e => e.CuaHang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiaChi).HasMaxLength(100);

            entity.HasOne(d => d.CuaHangNavigation).WithMany(p => p.CuaHangChiNhanhs)
                .HasForeignKey(d => d.CuaHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HDCN_HopDong_MaCH");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK__DonHang__129584AD2C3393D0");

            entity.ToTable("DonHang");

            entity.Property(e => e.MaDonHang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DcgiaoHang)
                .HasMaxLength(100)
                .HasColumnName("DCGiaoHang");
            entity.Property(e => e.HinhThucTt)
                .HasMaxLength(30)
                .HasColumnName("HinhThucTT");
            entity.Property(e => e.MaCh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaCH");
            entity.Property(e => e.MaKh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaKH");
            entity.Property(e => e.TinhTrang).HasMaxLength(30);

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaCh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DonHang_DoiTac");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DonHang_KhachHang");
        });

        modelBuilder.Entity<HopDong>(entity =>
        {
            entity.HasKey(e => e.MaHopDong).HasName("PK__HopDong__36DD43420DAF0CB0");

            entity.ToTable("HopDong");

            entity.Property(e => e.MaHopDong)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChiNhanhNh)
                .HasMaxLength(50)
                .HasColumnName("ChiNhanhNH");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NgDaiDien)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NganHang).HasMaxLength(50);
            entity.Property(e => e.PhiKichHoat).HasDefaultValueSql("((1000000))");
            entity.Property(e => e.SoTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SoTK");
            entity.Property(e => e.TgbatDau)
                .HasColumnType("datetime")
                .HasColumnName("TGBatDau");
            entity.Property(e => e.TgketThuc)
                .HasColumnType("datetime")
                .HasColumnName("TGKetThuc");

            entity.HasOne(d => d.NgDaiDienNavigation).WithMany(p => p.HopDongs)
                .HasForeignKey(d => d.NgDaiDien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HopDong_TTDaiDien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E1367E606");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTK");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.MaTk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KhachHang_TaiKhoan");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A182C9B23");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Loai).HasMaxLength(30);
            entity.Property(e => e.MaTk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTK");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaTk)
                .HasConstraintName("FK_NhanVien_TaiKhoan");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__TaiKhoan__2725007003317E3D");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaTk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTK");
            entity.Property(e => e.LoaiTk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LoaiTK");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('Kich hoat')");
        });

        modelBuilder.Entity<TaiXe>(entity =>
        {
            entity.HasKey(e => e.MaTx).HasName("PK__TaiXe__272500451CF15040");

            entity.ToTable("TaiXe");

            entity.Property(e => e.MaTx)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTX");
            entity.Property(e => e.BienSoXe)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KhuVuc).HasMaxLength(50);
            entity.Property(e => e.MaTk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTK");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.PhiThueChan).HasDefaultValueSql("((50000))");
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SoTk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SoTK");
            entity.Property(e => e.TenTx)
                .HasMaxLength(50)
                .HasColumnName("TenTX");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.TaiXes)
                .HasForeignKey(d => d.MaTk)
                .HasConstraintName("FK_TaiXe_TaiKhoan");
        });

        modelBuilder.Entity<ThongTinDaiDien>(entity =>
        {
            entity.HasKey(e => e.MaNgDaiDien).HasName("PK__ThongTin__3ADFA7DE7F60ED59");

            entity.ToTable("ThongTinDaiDien");

            entity.Property(e => e.MaNgDaiDien)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<ThongTinDoiTac>(entity =>
        {
            entity.HasKey(e => e.MaCuaHang).HasName("PK__ThongTin__0840BCA607F6335A");

            entity.ToTable("ThongTinDoiTac");

            entity.Property(e => e.MaCuaHang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaTK");
            entity.Property(e => e.NgDaiDien)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SlchiNhanh).HasColumnName("SLChiNhanh");
            entity.Property(e => e.TenCuaHang).HasMaxLength(50);
            entity.Property(e => e.TgdongCua).HasColumnName("TGDongCua");
            entity.Property(e => e.TgmoCua).HasColumnName("TGMoCua");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.ThongTinDoiTacs)
                .HasForeignKey(d => d.MaTk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DoiTac_TaiKhoan");

            entity.HasOne(d => d.NgDaiDienNavigation).WithMany(p => p.ThongTinDoiTacs)
                .HasForeignKey(d => d.NgDaiDien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DoiTac_DaiDien");
        });

        modelBuilder.Entity<ThucDon>(entity =>
        {
            entity.HasKey(e => e.MaMon).HasName("PK__ThucDon__3A5B29A8276EDEB3");

            entity.ToTable("ThucDon");

            entity.Property(e => e.MaMon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaCh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaCH");
            entity.Property(e => e.MieuTaMon).HasMaxLength(100);
            entity.Property(e => e.TenMon).HasMaxLength(80);
            entity.Property(e => e.TinhTrang).HasMaxLength(30);

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.ThucDons)
                .HasForeignKey(d => d.MaCh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThucDon_DoiTac");
        });

        modelBuilder.Entity<XacNhanHopDong>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK_XNHD");

            entity.ToTable("XacNhanHopDong");

            entity.Property(e => e.MaHd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaCh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaCH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNV");
            entity.Property(e => e.TinhTrang)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.MaChNavigation).WithMany(p => p.XacNhanHopDongs)
                .HasForeignKey(d => d.MaCh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_XNHD_CH");

            entity.HasOne(d => d.MaHdNavigation).WithOne(p => p.XacNhanHopDong)
                .HasForeignKey<XacNhanHopDong>(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_XNHD_HD");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.XacNhanHopDongs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_XNHD_NV");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
