using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.BLL.Entities
{
    public class BienEchange
    {
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

        public BienEchange(int id, int idMembre, string titre, string desCourte, string descLong, int nombrePerson, int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire, bool isEnabled, DateTime? disabledDate, string latitude, string longitude, DateTime dateCreation)
        {
            IdBien = id;
            IdMembre = idMembre;
            Titre = titre;
            DescCourte = desCourte;
            DescLong = descLong;
            NombrePerson = nombrePerson;
            Pays = pays;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assuranceObligatoire;
            IsEnabled = isEnabled;
            DisabledDate = disabledDate;
            Latitude = latitude;
            Longitude = longitude;
            DateCreation = dateCreation;
        }
        // To be continue here...!!!
    }
}
