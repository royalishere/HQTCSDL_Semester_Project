using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string TenNv { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string? Loai { get; set; }

    public int? Luong { get; set; }

    public string? MaTk { get; set; }

    public virtual TaiKhoan? MaTkNavigation { get; set; }

    public virtual ICollection<XacNhanHopDong> XacNhanHopDongs { get; } = new List<XacNhanHopDong>();
}
