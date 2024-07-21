using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class HoaDonHh
{
    public string MaHd { get; set; } = null!;

    public string? MaHh { get; set; }

    public string? MaKh { get; set; }

    public float? TongTien { get; set; }

    public virtual HangHoa? MaHhNavigation { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }
}
