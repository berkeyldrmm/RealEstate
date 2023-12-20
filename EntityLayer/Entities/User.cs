using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User : IdentityUser<string>
    {
        public IEnumerable<Alici> Alicilar { get; set; }
        public IEnumerable<Satici> Saticilar { get; set; }
        public IEnumerable<Ilan> Ilanlar { get; set; }
        public IEnumerable<Talep> Talepler { get; set; }
    }
}
