
using EntityLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Ilan
{
    public string Id { get; set; }
    public string IlanBaslik { get; set; }
    public int IlanTalepTipiId { get; set; }
    public IlanTalepTipi IlanTalepTipi { get; set; }
    public string SaticiId { get; set; }
    public Danisan Satici { get; set; }
    public decimal PortfoyFiyati { get; set; }
    public decimal Komisyon { get; set; }
    public decimal Kazanc { get; set; }
    public DateTime KayitTarihi { get; set; }
    public Arsa? Arsa { get; set; }
    public Tarla? Tarla { get; set; }
    public Daire? Daire { get; set; }
    public Dukkan? Dukkan { get; set; }
    public Depo? Depo { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public bool SatisDurumu { get; set; }
    public string SatilikMiKiralikMi { get; set; }
    public string? Detaylar { get; set; }
    public string Sehir { get; set; }
    public string Semt { get; set; }
    public string Mahalle { get; set; }
}
