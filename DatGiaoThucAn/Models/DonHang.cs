using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class DonHang
{
    public string MaDonHang { get; set; } = null!;

    public string MaCh { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public int? PhiSanPham { get; set; }

    public int? PhiVanChuyen { get; set; }

    public string? HinhThucTt { get; set; }

    public string? DcgiaoHang { get; set; }

    public string? TinhTrang { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; } = new List<ChiTietDonHang>();

    public virtual ChiTietGiaoHang? ChiTietGiaoHang { get; set; }

    public virtual ThongTinDoiTac MaChNavigation { get; set; } = null!;

    public virtual KhachHang MaKhNavigation { get; set; } = null!;
}
