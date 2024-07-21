using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? Cmnd { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? HinhThuc { get; set; }

    public virtual ICollection<Ghe> Ghes { get; set; } = new List<Ghe>();

    public virtual HinhThuc? HinhThucNavigation { get; set; }

    public virtual ICollection<HoaDonHh> HoaDonHhs { get; set; } = new List<HoaDonHh>();
}
