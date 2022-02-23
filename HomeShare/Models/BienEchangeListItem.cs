using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models
{
    public class BienEchangeListItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdBien { get; set; }
        public string Titre { get; set; }
        public string DescCourte { get; set; }
        public int Pays { get; set; }
        public string Photo { get; set; }
    }
}
