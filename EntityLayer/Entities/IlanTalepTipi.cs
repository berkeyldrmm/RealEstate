﻿using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class IlanTalepTipi
{
    public IlanTalepTipi()
    {
        Ilanlar = new List<Ilan>();
        Talepler = new List<Talep>();
    }
    public int Id { get; set; }
    public string TipAdi { get; set; }
    public IEnumerable<Ilan> Ilanlar { get; set; }
    public IEnumerable<Talep> Talepler { get; set; }
}
