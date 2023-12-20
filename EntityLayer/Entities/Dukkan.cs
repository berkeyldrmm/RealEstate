using EntityLayer.Abstract;
using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Dukkan : IPortfoy
{
    public string Id { get; set; }
    public int MetrekareBrut { get; set; }
    public int MetrekareNet { get; set; }
    public int OdaSayisi { get; set; }
    public int BinaYasi { get; set; }
    public int? BulunduguKat { get; set; }
    public int? KatSayisi { get; set; }
    public string Isıtma { get; set; }
    public int? BanyoSayisi { get; set; }
    public int? BalkonSayisi { get; set; }
    public bool? Asansor { get; set; }
    public bool? Otopark { get; set; }
    public bool EsyaliMi { get; set; }
    public string? KullanimDurumu { get; set; }
    public bool? SiteMi { get; set; }
    public bool? KrediyeUygun { get; set; }
    public int Aidat { get; set; }
    public decimal Fiyat { get; set; }
    public string SatilikKiralik { get; set; }
}
