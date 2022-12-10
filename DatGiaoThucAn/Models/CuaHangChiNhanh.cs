using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class CuaHangChiNhanh
{
    public int ChiNhanh { get; set; }

    public string CuaHang { get; set; } = null!;

    public string? DiaChi { get; set; }

    public virtual ThongTinDoiTac CuaHangNavigation { get; set; } = null!;
}
