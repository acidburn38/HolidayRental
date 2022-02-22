using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayRental.DAL.Entities
{
    public class AvisMembreBien
    {
        public int IdAvis { get; set; }
        public int IdMembre { get; set; }
        public int Ibien { get; set; }
        public int Note { get; set; }
        public string Message { get; set; }
        public DateTime DateAvis { get; set; }
        public bool Approuve { get; set; }
    }
}
