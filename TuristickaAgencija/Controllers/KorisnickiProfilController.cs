using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuristickaAgencija.EF;
using TuristickaAgencija.ViewModel;
using TuristickaAgencija.Helper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TuristickaAgencija.Controllers
{
    public class KorisnickiProfilController : Controller
    {
        private MojContext _db;
        public KorisnickiProfilController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            KorisnickiProfilIndexVM model = new KorisnickiProfilIndexVM();
            var logiranikorisnik = HttpContext.GetLogiraniKorisnik();
            var zaposlenik = _db.Zaposlenici.FirstOrDefault(s => s.KorisnickiNalogId == logiranikorisnik.KorisnickiNalogId);
            var putnik = _db.PutnikKorisnik.FirstOrDefault(s => s.KorisnickiNalogId == logiranikorisnik.KorisnickiNalogId);


            if (zaposlenik!=null)
            {
                var korisnik = _db.Klijent.FirstOrDefault(x => x.Id == zaposlenik.KorisnikID);
                model.Ime = korisnik.Ime;
                model.Prezime = korisnik.Prezime;
                model.JMBG = korisnik.JMBG;
                model.Kontakt = korisnik.Kontakt;
                model.DatumRodjenja = korisnik.DatumRodjenja;
                model.KorisnickoIme = zaposlenik.KorisnickiNalog.KorisnickoIme;
                model.Password = zaposlenik.KorisnickiNalog.Lozinka;
               

            }
            else
            {
                var korisnik = _db.Klijent.FirstOrDefault(x => x.Id == putnik.KorisnikId);
                model.Ime = korisnik.Ime;
                model.Prezime = korisnik.Prezime;
                model.JMBG = korisnik.JMBG;
                model.Kontakt = korisnik.Kontakt;
                model.DatumRodjenja = korisnik.DatumRodjenja;
                model.KorisnickoIme = putnik.KorisnickiNalog.KorisnickoIme;
                model.Password = putnik.KorisnickiNalog.Lozinka;
               
                
            }





            return View("Prikazi", model);
        }
        public IActionResult Uredi(int id)
        {
            KorisnickiProfilUrediVM model = new KorisnickiProfilUrediVM();
            var logiranikorisnik = HttpContext.GetLogiraniKorisnik();
            var zaposlenik = _db.Zaposlenici.FirstOrDefault(s => s.KorisnickiNalogId == logiranikorisnik.KorisnickiNalogId);
            var putnik = _db.PutnikKorisnik.FirstOrDefault(s => s.PutnikKorisnikId == logiranikorisnik.KorisnickiNalogId);


            if (zaposlenik!=null)
            {
                var korisnik = _db.Klijent.FirstOrDefault(x => x.Id == zaposlenik.KorisnikID);
                model.Ime = korisnik.Ime;
                model.Prezime = korisnik.Prezime;
                model.JMBG = korisnik.JMBG;
                model.Kontakt = korisnik.Kontakt;
                model.DatumRodjenja = korisnik.DatumRodjenja;
                model.KorisnickoIme = zaposlenik.KorisnickiNalog.KorisnickoIme;
                model.Password = zaposlenik.KorisnickiNalog.Lozinka;
               


            }
            else
            {
                var korisnik = _db.Klijent.FirstOrDefault(x => x.Id == putnik.KorisnikId);
                model.Ime = korisnik.Ime;
                model.Prezime = korisnik.Prezime;
                model.JMBG = korisnik.JMBG;
                model.Kontakt = korisnik.Kontakt;
                model.DatumRodjenja = korisnik.DatumRodjenja;
                model.KorisnickoIme = putnik.KorisnickiNalog.KorisnickoIme;
                model.Password = putnik.KorisnickiNalog.Lozinka;
                //model.Grad = _db.Gradovi.Select(o => new SelectListItem(o.NazivGrada, o.Id.ToString())).ToList();

            }
            return View("Uredi", model);
        }
        public IActionResult Snimi(KorisnickiProfilUrediVM model)
        {
            var logiranikorisnik = HttpContext.GetLogiraniKorisnik();
            var zaposlenik = _db.Zaposlenici.FirstOrDefault(s => s.KorisnickiNalogId == logiranikorisnik.KorisnickiNalogId);
            var putnik = _db.PutnikKorisnik.FirstOrDefault(s => s.KorisnickiNalogId == logiranikorisnik.KorisnickiNalogId);

            if (zaposlenik!=null)
            {
                var korisnik = _db.Klijent.FirstOrDefault(x => x.Id == zaposlenik.KorisnikID);

                korisnik.Kontakt = model.Kontakt;
                zaposlenik.KorisnickiNalog.KorisnickoIme = model.KorisnickoIme;
                zaposlenik.KorisnickiNalog.Lozinka = model.Password;

            }
            else
            {
                var korisnik = _db.Klijent.FirstOrDefault(x => x.Id == putnik.KorisnikId);

                korisnik.Kontakt = model.Kontakt;
                zaposlenik.KorisnickiNalog.KorisnickoIme = model.KorisnickoIme;
                zaposlenik.KorisnickiNalog.Lozinka = model.Password;

            }

            _db.SaveChanges();
            return Redirect("Prikazi");
        }
    }
}