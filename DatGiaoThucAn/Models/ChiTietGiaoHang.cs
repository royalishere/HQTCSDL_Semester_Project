using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class ChiTietGiaoHang
{
    public string MaDonHang { get; set; } = null!;

    public string? MaTx { get; set; }

    public string TinhTrangGiaoHang { get; set; } = null!;

    public virtual DonHang MaDonHangNavigation { get; set; } = null!;

    public virtual TaiXe? MaTxNavigation { get; set; }
}
