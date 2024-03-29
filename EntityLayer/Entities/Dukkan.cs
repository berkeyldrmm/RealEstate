﻿
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Dukkan : Portfoy
{
    public int MetrekareBrut { get; set; }
    public string? AdaNo { get; set; }
    public string? ParselNo { get; set; }
    public string OdaSayisi { get; set; }
    public string BinaYasi { get; set; }
    public int? BulunduguKat { get; set; }
    public int? KatSayisi { get; set; }
    public string Isıtma { get; set; }
    public bool Asansor { get; set; }
    public bool Otopark { get; set; }
    public bool EsyaliMi { get; set; }
    public string? KullanimDurumu { get; set; }
    public bool KrediyeUygun { get; set; }
    public int Aidat { get; set; }
}
