using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class TalepModelDTO
    {
        public string RadioForAlici { get; set; }
        public string TalepBaslik { get; set; }
        public string? AliciId { get; set; } = string.Empty;
        public string? AliciIsimSoyisim { get; set; } = string.Empty;
        public string? AliciMail { get; set; } = string.Empty;
        public string? AliciTelNo { get; set; } = string.Empty;
        public string IlanTipi { get; set; } = string.Empty;
        public IEnumerable<string> OdaSayisi { get; set; }
        public string SatilikMiKiralikMi { get; set; } = string.Empty;
        public string Sehir { get; set; }
        public IEnumerable<string> Semt { get; set; }
        public decimal MinFiyat { get; set; }
        public decimal MaxFiyat { get; set; }
        public string? Detaylar { get; set; } = string.Empty;

    }
}
