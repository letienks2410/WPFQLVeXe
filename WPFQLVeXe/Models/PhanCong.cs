using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class PhanCong
{
    public string? MaNv { get; set; }

    public DateOnly? NgayDi { get; set; }

    public string MaTuyen { get; set; } = null!;

    public string? MaPx { get; set; }

    public virtual TuyenXe MaTuyenNavigation { get; set; } = null!;
}
