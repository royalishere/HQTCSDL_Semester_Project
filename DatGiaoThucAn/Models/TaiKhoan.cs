using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class TaiKhoan
{
    public string MaTk { get; set; } = null!;

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string LoaiTk { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<KhachHang> KhachHangs { get; } = new List<KhachHang>();

    public virtual ICollection<NhanVien> NhanViens { get; } = new List<NhanVien>();

    public virtual ICollection<TaiXe> TaiXes { get; } = new List<TaiXe>();

    public virtual ICollection<ThongTinDoiTac> ThongTinDoiTacs { get; } = new List<ThongTinDoiTac>();
}
