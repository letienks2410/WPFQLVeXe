using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class XeKhach
{
    public string SoXe { get; set; } = null!;

    public string HangSx { get; set; } = null!;

    public virtual ICollection<LichTrinh> LichTrinhs { get; set; } = new List<LichTrinh>();

    public virtual ICollection<VeXe> VeXes { get; set; } = new List<VeXe>();
}
