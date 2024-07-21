using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class HangHoa
{
    public string MaHh { get; set; } = null!;

    public string? LoaiHh { get; set; }

    public double? KhoiLuong { get; set; }

    public float? Phi { get; set; }

    public string? NguoiGui { get; set; }

    public string? NguoiNhan { get; set; }

    public string? NhanVienNhan { get; set; }

    public virtual ICollection<HoaDonHh> HoaDonHhs { get; set; } = new List<HoaDonHh>();

    public virtual NhanVien? NhanVienNhanNavigation { get; set; }
}
