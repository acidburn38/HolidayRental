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
                entity.idBien,
                entity.idMembre,
                entity.titre,
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
                entity.isEnabled,
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
                idBien = entity.idBien,
                idMembre = entity.idMembre,
                titre = entity.titre,
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
                isEnabled = entity.isEnabled,
                DisabledDate = entity.DisabledDate,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                DateCreation = entity.DateCreation
            };
        }
    }
}
