using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class PaysDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdPays { get; set; }
        public string Libelle { get; set; }
    }
}
