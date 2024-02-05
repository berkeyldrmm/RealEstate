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
        public string MetrekareNet { get; set; }
        public decimal? MetrekareFiyat { get; set; }
        public Ilan Ilan { get; set; }
    }
}
