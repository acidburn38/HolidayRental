using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class BienEchangeDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; }
        public int IdMembre { get; set; }

        [DisplayName("Titre:")]
        public string Titre { get; set; }
        public string DescCourte { get; set; }

        [DisplayName("Description:")]
        public string DescLong { get; set; }

        [DisplayName("Nombre de personne max:")]
        public int NombrePerson { get; set; }

        [DisplayName("Pays:")]
        public int Pays { get; set; }

        [DisplayName("Ville:")]
        public string Ville { get; set; }

        [DisplayName("Rue:")]
        public string Rue { get; set; }

        [DisplayName("Numéro:")]
        public string Numero { get; set; }

        [DisplayName("Code postal:")]
        public string CodePostal { get; set; }

        [DisplayName("")]
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime? DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
