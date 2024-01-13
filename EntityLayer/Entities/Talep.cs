
using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Talep
{
    public string Id { get; set; }
    public string AliciId { get; set; }
    public Alici Alici { get; set; }
    public decimal MinFiyat { get; set; }
    public decimal MaxFiyat { get; set; }
    public int IlanTalepTipiId { get; set; }
    public IlanTalepTipi IlanTalepTipi { get; set; }
    public DateTime KayitTarihi { get; set; }
    public int PortfoyId { get; set; }
    public Portfoy Portfoy { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public string SatilikMiKiralikMi { get; set; }
}
