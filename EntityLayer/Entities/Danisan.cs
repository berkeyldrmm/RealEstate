using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Danisan
{
    public Danisan()
    {
        Ilanlar = new List<Ilan>();
    }
    public string Id { get; set; }
    public string AdSoyad { get; set; }
    public string? TelefonNo { get; set; }
    public string? MailAdresi { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public IEnumerable<Ilan> Ilanlar { get; set; }
}
