using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string? TenNv { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? Cmnd { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? LoaiNv { get; set; }

    public string? BiXoa { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();

    public virtual LoaiNhanVien? LoaiNvNavigation { get; set; }

    public virtual ICollection<VeXe> VeXes { get; set; } = new List<VeXe>();
}
