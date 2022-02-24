using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = HolidayRental.DAL.Entities;
using B = HolidayRental.BLL.Entities;

namespace HolidayRental.BLL.Handlers
{
    public static class Mapper
    {
        public static B.BienEchange ToBLL(this D.BienEchange entity)
        {
            if (entity == null) return null;
            return new B.BienEchange(
                entity.IdBien,
                entity.IdMembre,
                entity.Titre,
                entity.DescCourte,
                entity.DescLong,
                entity.NombrePerson,
                entity.Pays,
                entity.Ville,
                entity.Rue,
                entity.Numero,
                entity.CodePostal,
                entity.Photo,
                entity.AssuranceObligatoire,
                entity.IsEnabled,
                entity.DisabledDate,
                entity.Latitude,
                entity.Longitude,
                entity.DateCreation
                );
        }


        public static D.BienEchange ToDAL(this B.BienEchange entity)
        {
            if (entity == null) return null;
            return new D.BienEchange
            {
                IdBien = entity.IdBien,
                IdMembre = entity.IdMembre,
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                NombrePerson = entity.NombrePerson,
                Pays = entity.Pays,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                IsEnabled = entity.IsEnabled,
                DisabledDate = entity.DisabledDate,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                DateCreation = entity.DateCreation
            };
        }

        public static B.Pays ToBLL(this D.Pays entity)
        {
            if (entity == null) return null;
            return new B.Pays
            {
                IdPays = entity.IdPays,
                Libelle = entity.Libelle
            };
               
        }
        public static D.Pays ToDAL(this B.Pays entity)
        {
            if (entity == null) return null;
            return new D.Pays
            {
                IdPays = entity.IdPays,
                Libelle = entity.Libelle
            };
        }
    }
}
