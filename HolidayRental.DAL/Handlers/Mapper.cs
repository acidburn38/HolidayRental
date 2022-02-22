using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayRental.DAL.Handlers
{
    public class Mapper
    {
        public static BienEchange ToBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new BienEchange
            {
                Id = (int)record[nameof(BienEchange.Id)],
                IdMembre = (int)record[nameof(BienEchange.IdMembre)],
                Titre = (string)record[nameof(BienEchange.Titre)],
                DescCourte = (string)record[nameof(BienEchange.DescCourte)],
                DescLong = (string)record[nameof(BienEchange.DescLong)],
                NombrePerson = (int)record[nameof(BienEchange.NombrePerson)],
                Pays = (int)record[nameof(BienEchange.Pays)],
                Ville = (string)record[nameof(BienEchange.Ville)],
                Rue = (string)record[nameof(BienEchange.Rue)],
                Numero = (string)record[nameof(BienEchange.Numero)],
                CodePostal = (string)record[nameof(BienEchange.CodePostal)],
                Photo = (string)record[nameof(BienEchange.Photo)],
                AssuranceObligatoire = (bool)record[nameof(BienEchange.AssuranceObligatoire)],
                IsEnabled = (bool)record[nameof(BienEchange.IsEnabled)],
                DisabledDate = (DateTime)record[nameof(BienEchange.DisabledDate)],
                Latitude = (string)record[nameof(BienEchange.Latitude)],
                Longitude = (string)record[nameof(BienEchange.Longitude)],
                DateCreation = (DateTime)record[nameof(BienEchange.DateCreation)],

            };
        }
    }
}
