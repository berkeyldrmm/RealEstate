
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
        public decimal? MetrekareFiyat { get; set; }
        public Ilan? Ilan { get; set; }
    }
}
