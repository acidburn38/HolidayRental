using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class MembreCreateForm
    {
        [Required]
        [DisplayName("Prénom")]
        public string Prenom { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Pays { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        [DisplayName("Mot de passe")]
        public string Password { get; set; }
    }
}
