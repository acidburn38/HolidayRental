using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayRental.BLL.Entities;
using HoliDayRental.Models;

namespace HoliDayRental.Handlers
{
    public static class Mapper
    {
        public static BienEchangeListItem ToListItem(this BienEchange entity)
        {
            if (entity == null) return null;
            return new BienEchangeListItem
            {
                Titre = entity.Titre,
                DescCourte = entity.DescCourte,
                Pays = entity.Pays,
                Photo = entity.Photo
            };
        }
        public static BienEchangeDetails ToDetails(this BienEchange entity)
        {
            if (entity == null) return null;
            return new BienEchangeDetails
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
    }
}
