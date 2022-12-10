using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class ThongTinDaiDien
{
    public string MaNgDaiDien { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Cccd { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<HopDong> HopDongs { get; } = new List<HopDong>();

    public virtual ICollection<ThongTinDoiTac> ThongTinDoiTacs { get; } = new List<ThongTinDoiTac>();
}
