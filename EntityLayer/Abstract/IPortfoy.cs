using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IPortfoy
    {
        public string Id { get; set; }
        public decimal Fiyat { get; set; }
        public string SatilikKiralik { get; set; }
        public string MetrekareNet { get; set; }
        public Ilan? Ilan { get; set; }
        public string? TalepId { get; set; }
        public Talep? Talep { get; set; }
    }
}
