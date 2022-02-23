﻿using System;
using System.Collections.Generic;
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
        public string Titre { get; set; }
        public string DescCourte { get; set; }
        public string DescLong { get; set; }
        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime? DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
