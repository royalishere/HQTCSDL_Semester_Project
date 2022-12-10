using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string TenKh { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public string Sdt { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string Email { get; set; } = null!;

    public string MaTk { get; set; } = null!;

    public virtual ICollection<DonHang> DonHangs { get; } = new List<DonHang>();

    public virtual TaiKhoan MaTkNavigation { get; set; } = null!;
}
