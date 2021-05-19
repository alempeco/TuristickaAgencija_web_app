using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.EF;
using TuristickaAgencija.ViewModel;

namespace TuristickaAgencija.Controllers
{
    public class KlijentPutovanjaController : Controller
    {
        private MojContext _db;

        public KlijentPutovanjaController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<PutovanjaPrikaziVM> putovanja = _db.Putovanja.Select(x => new PutovanjaPrikaziVM
            {
               PutovanjaId=x.PutovanjaId,
               NazivPutovanja=x.NazivPutovanja,
               OpisPutovanja=x.OpisPutovanja,
               CijenaPutovanja=x.CijenaPutovanja,
               DatumPolaska=x.DatumPolaska.ToString(),
               DatumDolaska=x.DatumDolaska.ToString(),
               BrojPutnika=x.BrojPutnika,
               Prevoz=x.Prevoz.Firma.Naziv,
               Smjestaj=x.Smjestaj.NazivSmjestaja
            }).ToList();
            return View(putovanja);
        }
    }
}
