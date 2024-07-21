using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class HoaDonVe
{
    public string? MaHd { get; set; }

    public string? MaVe { get; set; }

    public string? MaKh { get; set; }

    public int? SoLuong { get; set; }

    public float? TongTien { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual VeXe? MaVeNavigation { get; set; }
}
