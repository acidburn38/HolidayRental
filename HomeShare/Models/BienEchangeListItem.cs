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
        [DisplayName("")]
        public string Photo { get; set; }
    }
}
