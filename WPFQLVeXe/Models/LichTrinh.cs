using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class LichTrinh
{
    public string MaTuyen { get; set; } = null!;

    public DateOnly NgayDi { get; set; }

    public DateOnly NgayDen { get; set; }

    public string SoXe { get; set; } = null!;

    public virtual TuyenXe MaTuyenNavigation { get; set; } = null!;

    public virtual XeKhach SoXeNavigation { get; set; } = null!;
}
