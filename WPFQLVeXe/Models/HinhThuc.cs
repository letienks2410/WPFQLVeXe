using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class HinhThuc
{
    public string LoaiHt { get; set; } = null!;

    public string? TenHt { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
