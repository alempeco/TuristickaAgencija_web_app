using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.EF;
using TuristickaAgencija.EntityModels;
using TuristickaAgencija.Helper;
using TuristickaAgencija.ViewModel;

namespace TuristickaAgencija.Controllers
{
    public class ObavijestiController : Controller
    {
        private MojContext _db;


        public ObavijestiController(MojContext db)
        {
            _db = db;

        }
        [Autorizacija(zaposlenik: true, putnikkorisnik: true)]

        public IActionResult Index()
        {

            return View();
        }

        [Autorizacija(zaposlenik: true, putnikkorisnik: true)]

        public IActionResult Prikazi(int trenutnaStr = 1, int velicinaStr = 1)
        {
            List<ObavijestiPrikaziVM> model = _db.Obavijesti.Select(
                k => new ObavijestiPrikaziVM
                {
                    ObavijestID = k.ObavijestiId,
                    Naziv = k.Naziv,
                    Sadrzaj = k.Sadrzaj,
                    Datum = k.Datum,
                    Slika = k.Slika,
                }).ToList();

            var items = model.OrderBy(x => x.Naziv).Skip((trenutnaStr - 1) * velicinaStr).
          Take(velicinaStr).ToList();
            ViewData["trenutno"] = trenutnaStr;
            ViewData["ukupno"] = _db.Obavijesti.Count();

            return View(items);

        }
        [Autorizacija(zaposlenik: true, putnikkorisnik: false)]

        public IActionResult Dodaj()
        {
            ObavijestiDodajVM model = new ObavijestiDodajVM();
            return View(model);

        }
        [Autorizacija(zaposlenik: true, putnikkorisnik: false)]

        public IActionResult Snimi(ObavijestiDodajVM input)
        {
            if (!ModelState.IsValid)
            {
                return View("Dodaj", input);

            }
            Obavijesti o;
            if (input.ObavijestID == 0)
            {
                o = new Obavijesti();
                _db.Add(o);

            }
            else
            {
                o = _db.Obavijesti.Find(input.ObavijestID);

            }
            if (input.Slika != null)
            {
                var memoryStream = new MemoryStream();


                input.Slika.CopyTo(memoryStream);
                var j = memoryStream.ToArray();
                o.Slika = j;

            }


            o.Naziv = input.Naziv;
            o.Sadrzaj = input.Sadrzaj;
            o.Datum = input.Datum;

            _db.SaveChanges();
          

            int TrenutnaStranica = 1, VelicinaStranice = 1;

            return Redirect("/Obavijesti/Prikazi?velicinaStr=" + VelicinaStranice + "&trenutnaStr=" + TrenutnaStranica);


        }
        [Autorizacija(zaposlenik: true, putnikkorisnik: false)]

        public IActionResult Uredi(int ObavijestID)
        {

            Obavijesti o = _db.Obavijesti.Find(ObavijestID);
            if (o == null)
            {
               
                return RedirectToAction(nameof(Prikazi));
            }

            ObavijestiDodajVM model = new ObavijestiDodajVM();
            model.ObavijestID = o.ObavijestiId;
            model.Naziv = o.Naziv;
            model.Sadrzaj = o.Sadrzaj;
            model.Datum = o.Datum;



            return View(model);
        }
        [Autorizacija(zaposlenik: true, putnikkorisnik: false)]

        public IActionResult Obrisi(int ObavijestID)
        {
            Obavijesti o = _db.Obavijesti.Find(ObavijestID);
            if (o == null)
            {
               

            }
            else
            {
                _db.Remove(o);

                _db.SaveChanges();
                

            }
            return RedirectToAction(nameof(Prikazi));
        }

    }
}