using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class LoaiTk
{
    public string MaLoaiTk { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
