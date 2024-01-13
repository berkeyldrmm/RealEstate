
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Arsa : Portfoy
{
    public bool ImarDurumu { get; set; }
    public decimal? MetrekareFiyat { get; set; }
    public string? AdaNo { get; set; }
    public string? ParselNo { get; set; }
    public string? PaftaNo { get; set; }
    public bool KatKarsiliginaUygun { get; set; }
    public bool TapuDurumu { get; set; }
}
