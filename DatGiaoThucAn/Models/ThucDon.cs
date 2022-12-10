using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class ThucDon
{
    public string MaMon { get; set; } = null!;

    public string TenMon { get; set; } = null!;

    public string MaCh { get; set; } = null!;

    public string? MieuTaMon { get; set; }

    public int Gia { get; set; }

    public string? TinhTrang { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; } = new List<ChiTietDonHang>();

    public virtual ThongTinDoiTac MaChNavigation { get; set; } = null!;
}
