using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.EF;
using TuristickaAgencija.ViewModel;

namespace TuristickaAgencija.Controllers
{
    public class KlijentObavijestiController : Controller
    {
        private MojContext _db;

        public KlijentObavijestiController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ObavijestiPrikaziVM> obavijesti = _db.Obavijesti.Select(x => new ObavijestiPrikaziVM
            {
               ObavijestID=x.ObavijestiId,
               Naziv=x.Naziv,
               Sadrzaj=x.Sadrzaj,
               Datum=x.Datum,
               Slika=x.Slika,
               SlikaString=x.Slika.ToString()
            }).ToList();
            return View(obavijesti);
        }
    }
}

