using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayRental.DAL.Entities
{
    public class OptionsBien
    {
        public int IdOption { get; set; }
        public int IdBien { get; set; }
        public string Valeur { get; set; }
    }
}
