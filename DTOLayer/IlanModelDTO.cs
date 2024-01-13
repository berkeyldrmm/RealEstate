using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class IlanModelDTO
    {
        public string RadioForSatici { get; set; }
        public string? SaticiId { get; set; } = string.Empty;
        public string? SaticiIsimSoyisim { get; set; } = string.Empty;
        public string? SaticiMail { get; set; } = string.Empty;
        public string? SaticiTelNo { get; set; } = string.Empty;
        public string IlanTipi { get; set; } = string.Empty;
        public string MetrekareNet { get; set; } = string.Empty;
        public string? MetrekareBrut { get; set; } = string.Empty;
        public string? MetrekareFiyat { get; set; } = string.Empty;
        public string? AdaNo { get; set; } = string.Empty;
        public string? PaftaNo { get; set; } = string.Empty;
        public string? ParselNo { get; set; } = string.Empty;
        public string? ImarDurumu { get; set; } = string.Empty;
        public string? KatKarsiliginaUygun { get; set; } = string.Empty;
        public string? KrediyeUygun { get; set; } = string.Empty;
        public string? OdaSayisi { get; set; } = string.Empty;
        public string? BinaYasi { get; set; } = string.Empty;
        public string? BulunduguKat { get; set; } = string.Empty;
        public string? KatSayisi { get; set; } = string.Empty;
        public string? Isıtma { get; set; } = string.Empty;
        public string? BanyoSayisi { get; set; } = string.Empty;
        public string? BalkonSayisi { get; set; } = string.Empty;
        public string? Otopark { get; set; } = string.Empty;
        public string? Asansor { get; set; } = string.Empty;
        public string? Esyali { get; set; } = string.Empty;
        public string? KullanimDurumu { get; set; } = string.Empty;
        public string? SiteMi { get; set; } = string.Empty;
        public string? Aidat { get; set; } = string.Empty;
        public string? TapuDurumu { get; set; } = string.Empty;
        public string SatilikMiKiralikMi { get; set; } = string.Empty;
        public decimal Fiyat { get; set; }
        public string radioForKomisyon { get; set; } = string.Empty;
        public string? Komisyon { get; set; } = string.Empty;
        public string? Detaylar { get; set; } = string.Empty;
    }
}
