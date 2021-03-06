using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HoliDayRental.Models
{
    public class BienEchangeListItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; }

        [DisplayName("Titre")]
        public string Titre { get; set; }

        [DisplayName("Description")]
        public string DescCourte { get; set; }
        public int Pays { get; set; }
        public PaysDetails PaysP { get; set; }

        [DisplayName("Pays:")]
        public string PaysName { get { return this.PaysP?.Libelle; } }

        [DisplayName("")]
        public string Photo { get; set; }
    }
}
