using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class TaiKhoan
{
    public string TenDn { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? LoaiTk { get; set; }

    public virtual LoaiTk? LoaiTkNavigation { get; set; }
}
