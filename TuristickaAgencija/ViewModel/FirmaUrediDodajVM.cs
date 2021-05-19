using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.ViewModel
{
    public class FirmaUrediDodajVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Unesite naziv.")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Unesite grad.")]

        public int? GradID { get; set; }

        public List<SelectListItem> listaGradova { get; set;}
        [Required(ErrorMessage = "Unesite adresu.")]

        public string Adresa { get; set; }
        [Required(ErrorMessage = "Unesite broj ziro racuna.")]

        public string BrojZiroracuna { get; set; }
    }
}
