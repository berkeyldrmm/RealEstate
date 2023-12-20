using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class IlanTalepTipi
{
    public int Id { get; set; }
    public string TipAdi { get; set; }
    public int TipNo { get; set; }
    public IEnumerable<Ilan> Ilanlar { get; set; }
    public IEnumerable<Talep> Talepler { get; set; }
}
