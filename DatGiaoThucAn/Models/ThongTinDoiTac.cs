using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class ThongTinDoiTac
{
    public string MaCuaHang { get; set; } = null!;

    public string TenCuaHang { get; set; } = null!;

    public string NgDaiDien { get; set; } = null!;

    public int? SlchiNhanh { get; set; }

    public TimeSpan? TgmoCua { get; set; }

    public TimeSpan? TgdongCua { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string MaTk { get; set; } = null!;

    public virtual ICollection<CuaHangChiNhanh> CuaHangChiNhanhs { get; } = new List<CuaHangChiNhanh>();

    public virtual ICollection<DonHang> DonHangs { get; } = new List<DonHang>();

    public virtual TaiKhoan MaTkNavigation { get; set; } = null!;

    public virtual ThongTinDaiDien NgDaiDienNavigation { get; set; } = null!;

    public virtual ICollection<ThucDon> ThucDons { get; } = new List<ThucDon>();

    public virtual ICollection<XacNhanHopDong> XacNhanHopDongs { get; } = new List<XacNhanHopDong>();
}
