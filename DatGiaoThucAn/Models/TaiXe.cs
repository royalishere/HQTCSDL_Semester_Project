using System;
using System.Collections.Generic;

namespace DatGiaoThucAn.Models;

public partial class TaiXe
{
    public string MaTx { get; set; } = null!;

    public string TenTx { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public string? Cccd { get; set; }

    public string Sdt { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string BienSoXe { get; set; } = null!;

    public string? KhuVuc { get; set; }

    public string? SoTk { get; set; }

    public int? PhiThueChan { get; set; }

    public string? MaTk { get; set; }

    public virtual ICollection<ChiTietGiaoHang> ChiTietGiaoHangs { get; } = new List<ChiTietGiaoHang>();

    public virtual TaiKhoan? MaTkNavigation { get; set; }
}
