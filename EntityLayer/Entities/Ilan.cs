using EntityLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Ilan
{
    public string Id { get; set; }
    public int IlanTalepTipiId { get; set; }
    public IlanTalepTipi IlanTalepTipi { get; set; }
    public string SaticiId { get; set; }
    public Satici Satici { get; set; }
    public decimal Fiyat { get; set; }
    public DateTime KayitTarihi { get; set; }
    public int PortfoyId { get; set; }
    public IPortfoy Portfoy { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}
