using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class VeXe
{
    public string MaVe { get; set; } = null!;

    public string? MaGhe { get; set; }

    public string? MaKh { get; set; }

    public DateOnly? NgayDi { get; set; }

    public TimeOnly? GioDi { get; set; }

    public string? SoXe { get; set; }

    public float? GiaVe { get; set; }

    public string? NhanVienBv { get; set; }

    public virtual NhanVien? NhanVienBvNavigation { get; set; }

    public virtual XeKhach? SoXeNavigation { get; set; }
}
