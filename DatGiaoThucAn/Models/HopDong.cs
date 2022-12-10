using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class HopDong
{
    public string MaHopDong { get; set; } = null!;

    public string MaSoThue { get; set; } = null!;

    public string NgDaiDien { get; set; } = null!;

    public DateTime? TgbatDau { get; set; }

    public DateTime? TgketThuc { get; set; }

    public string SoTk { get; set; } = null!;

    public string? NganHang { get; set; }

    public string? ChiNhanhNh { get; set; }

    public int? PhiKichHoat { get; set; }

    public int? PhiHoaHong { get; set; }

    public virtual ThongTinDaiDien NgDaiDienNavigation { get; set; } = null!;

    public virtual XacNhanHopDong? XacNhanHopDong { get; set; }
}
