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
        public int MetrekareNet { get; set; }
    }
}
