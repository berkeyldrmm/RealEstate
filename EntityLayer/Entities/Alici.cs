using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Alici
{
    public Alici()
    {
        Talepler = new List<Talep>();
    }
    public string Id { get; set; }
    public string AdSoyad { get; set; }
    public string MailAdresi { get; set; }
    public string TelefonNo { get; set; }
    public IEnumerable<Talep> Talepler { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}
