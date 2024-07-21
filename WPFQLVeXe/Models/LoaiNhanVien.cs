using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class LoaiNhanVien
{
    public string MaLoaiNv { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
