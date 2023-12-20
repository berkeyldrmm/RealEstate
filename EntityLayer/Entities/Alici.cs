using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Alici
{
    public string Id { get; set; }
    public string AdSoyad { get; set; }
    public string MailAdresi { get; set; }
    public string TelefonNo { get; set; }
    public IEnumerable<Talep> Talepler { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}
