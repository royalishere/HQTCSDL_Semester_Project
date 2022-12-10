using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class XacNhanHopDong
{
    public string MaHd { get; set; } = null!;

    public string MaCh { get; set; } = null!;

    public string? MaNv { get; set; }

    public string? TinhTrang { get; set; }

    public virtual ThongTinDoiTac MaChNavigation { get; set; } = null!;

    public virtual HopDong MaHdNavigation { get; set; } = null!;

    public virtual NhanVien? MaNvNavigation { get; set; }
}
