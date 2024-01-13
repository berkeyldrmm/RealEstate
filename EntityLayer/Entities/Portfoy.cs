
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Portfoy : IPortfoy
    {
        public string Id { get; set; }
        public string MetrekareNet { get; set; }
        public Ilan? Ilan { get; set; }
        public string? TalepId { get; set; }
        public Talep? Talep { get; set; }
        public decimal Fiyat { get; set; }
        public string SatilikKiralik { get; set; }
    }
}
