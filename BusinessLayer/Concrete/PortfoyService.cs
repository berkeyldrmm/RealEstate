using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfoyService : IPortfoyService
    {
        private readonly IArsaService _arsaService;
        private readonly ITarlaService _tarlaService;
        private readonly IDaireService _daireService;
        private readonly IDukkanService _dukkanService;
        private readonly IDepoService _depoService;

        public PortfoyService(IArsaService arsaService, ITarlaService tarlaService, IDaireService daireService, IDukkanService dukkanService, IDepoService depoService)
        {
            _arsaService = arsaService;
            _tarlaService = tarlaService;
            _daireService = daireService;
            _dukkanService = dukkanService;
            _depoService = depoService;
        }

        [HttpPost]
        public async Task<bool> PortfoyEkle(Portfoy portfoy)
        {
            bool result = false;
            if (portfoy as Dukkan != null)
            {
                Dukkan dukkan = portfoy as Dukkan;
                result = await _dukkanService.Insert(dukkan);
            }
            if (portfoy as Arsa != null)
            {
                Arsa arsa = portfoy as Arsa;
                result = await _arsaService.Insert(arsa);
            }
            if (portfoy as Depo != null)
            {
                Depo depo = portfoy as Depo;
                result = await _depoService.Insert(depo);
            }
            if (portfoy as Daire != null)
            {
                Daire daire = portfoy as Daire;
                result = await _daireService.Insert(daire);
            }
            if (portfoy as Tarla != null)
            {
                Tarla tarla = portfoy as Tarla;
                result = await _tarlaService.Insert(tarla);
            }

            return result;
        }
    }
}
