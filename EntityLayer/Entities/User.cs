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
        public User()
        {
            Danisanlar = new List<Danisan>();
            Ilanlar = new List<Ilan>();
            Talepler = new List<Talep>();
        }
        public string NameSurname { get; set; }
        public IEnumerable<Danisan> Danisanlar { get; set; }
        public IEnumerable<Ilan> Ilanlar { get; set; }
        public IEnumerable<Talep> Talepler { get; set; }
    }
}
