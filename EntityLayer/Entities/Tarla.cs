
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Tarla : Portfoy
{
    public string Id { get; set; }
    public string MetrekareNet { get; set; }
    public decimal? MetrekareFiyat { get; set; }
    public Ilan? Ilan { get; set; }
    public bool ImarDurumu { get; set; }
    public string? AdaNo { get; set; }
    public string? ParselNo { get; set; }
    public string? PaftaNo { get; set; }
    public bool TapuDurumu { get; set; }
}
