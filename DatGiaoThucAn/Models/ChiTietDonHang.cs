using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class ChiTietDonHang
{
    public string MaDonHang { get; set; } = null!;

    public string MaMon { get; set; } = null!;

    public string? TuyChon { get; set; }

    public int? SoLuong { get; set; }

    public int? ThanhTien { get; set; }

    public virtual DonHang MaDonHangNavigation { get; set; } = null!;

    public virtual ThucDon MaMonNavigation { get; set; } = null!;
}
