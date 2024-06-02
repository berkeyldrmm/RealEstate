using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class IlanlarSayfasiDTO
    {
        public string Id { get; set; }
        public string IlanBaslik { get; set; }
        public string IlanTipi { get; set; }
        public string SaticiAdi { get; set; }
        public string PortfoyFiyati { get; set; }
        public string Komisyon { get; set; }
        public string Kazanc { get; set; }
        public bool SatisDurumu { get; set; }
        public string SatilikMiKiralikMi { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }

    }
}
