using EntityLayer.Abstract;
using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Tarla : IPortfoy
{
    public string Id { get; set; }
    public decimal? MetrekareFiyat { get; set; }
    public bool ImarDurumu { get; set; }
    public int MetrekareNet { get; set; }
    public int AdaNo { get; set; }
    public int ParselNo { get; set; }
    public int PaftaNo { get; set; }
    public bool TapuDurumu { get; set; }
    public bool KrediyeUygun { get; set; }
    public string SatilikKiralik { get; set; }
    public decimal Fiyat { get; set; }
}
