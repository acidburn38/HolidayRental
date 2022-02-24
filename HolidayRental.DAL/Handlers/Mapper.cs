using HolidayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
                IdBien = (int)record[nameof(BienEchange.IdBien)],
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
                DisabledDate = (record[nameof(BienEchange.DisabledDate)] is DBNull) ? null : (DateTime?)record[nameof(BienEchange.DisabledDate)],
                Latitude = (string)record[nameof(BienEchange.Latitude)],
                Longitude = (string)record[nameof(BienEchange.Longitude)],
                DateCreation = (DateTime)record[nameof(BienEchange.DateCreation)],
                
            };
        }

        public static Pays ToPays(IDataRecord record)
        {
            if (record is null) return null;
            return new Pays
            {
                IdPays = (int)record[nameof(Pays.IdPays)],
                Libelle = (string)record[nameof(Pays.Libelle)],
            };
        }

        public static Membre ToMembre(IDataRecord record)
        {
            if (record is null) return null;
            return new Membre
            {
                IdMembre = (int)record[nameof(Membre.IdMembre)],
                Nom = (string)record[nameof(Membre.Nom)],
                Prenom = (string)record[nameof(Membre.Prenom)],
                Email = (string)record[nameof(Membre.Email)],
                Pays = (int)record[nameof(Membre.Pays)],
                Telephone = (string)record[nameof(Membre.Telephone)],
                Login = (string)record[nameof(Membre.Login)],
                Password = (string)record[nameof(Membre.Password)],
            };
        }
    }
}
