using System;
using System.Collections.Generic;

namespace WPFQLVeXe.Models;

public partial class TuyenXe
{
    public string MaTuyen { get; set; } = null!;

    public string? DiaDiemDi { get; set; }

    public string? DiaDiemDen { get; set; }

    public TimeOnly? GioDi { get; set; }

    public TimeOnly? GioDen { get; set; }

    public virtual ICollection<Ghe> Ghes { get; set; } = new List<Ghe>();

    public virtual ICollection<LichTrinh> LichTrinhs { get; set; } = new List<LichTrinh>();

    public virtual PhanCong? PhanCong { get; set; }
}
