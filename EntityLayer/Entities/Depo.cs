using EntityLayer.Abstract;
using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Depo : IPortfoy
{
    public string Id { get; set; }
    public int MetrekareNet { get; set; }
    public int MetrekareFiyat { get; set; }
    public int AdaNo { get; set; }
    public int ParselNo { get; set; }
    public decimal Fiyat { get; set; }
    public string SatilikKiralik { get; set; }
}
