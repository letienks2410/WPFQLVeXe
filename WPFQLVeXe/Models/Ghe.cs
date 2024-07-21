using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class Ghe
{
    public string MaGhe { get; set; } = null!;

    public string? MaTuyen { get; set; }

    public string? MaKh { get; set; }

    public string? TinhTrang { get; set; }

    public string? SoXe { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual TuyenXe? MaTuyenNavigation { get; set; }
}
