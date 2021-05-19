using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.ViewModel
{
    public class PrevozDodajUrediVM
    {
        public int Id { get; set; }

        public int? FirmaID { get; set; }
        [Required(ErrorMessage = "Unesite firmu!")]
        public List<SelectListItem> Firma { get; set; }
        [Required(ErrorMessage = "Unesite tip prevoza!")]
        public string TipPrevoza { get; set; }

        public int BrojMjesta { get; set; }
        [Required(ErrorMessage = "Unesite cijenu prevoza!")]

        public float CijenaPoMjestu { get; set; }

 
    }
}
