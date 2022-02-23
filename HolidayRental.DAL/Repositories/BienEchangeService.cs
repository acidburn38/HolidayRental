using HolidayRental.Common.Repositories;
using HolidayRental.DAL.Entities;
using HolidayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HolidayRental.DAL.Repositories
{
    public class BienEchangeService : ServiceBase, IBienEchangeRepository<BienEchange>
    {
        public void Delete(int idBien)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [dbo].[BienEchange] WHERE [idBien] = @idBien,";
            SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = idBien };
            command.Parameters.Add(p_idBien);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public BienEchange Get(int idBien)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[DateCreation] FROM[dbo].[BienEchange] WHERE [idBien] = @idBien";
            SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = idBien };
            command.Parameters.Add(p_idBien);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) return Mapper.ToBienEchange(reader);
            return null;
        }

        public IEnumerable<BienEchange> Get()
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[DateCreation] FROM[dbo].[BienEchange]";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) yield return Mapper.ToBienEchange(reader);
        }

        public int Insert(BienEchange entity)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[BienEchange] 
            ([idMembre],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[DateCreation]) OUTPUT [inserted].[idBien]
            VALUES
            (@idMembre, @titre, @DescCourte, @DescLong, @NombrePerson, @Pays, @Ville, @Rue,@Numero, @CodePostal, @Photo, @AssuranceObligatoire, @isEnabled, @DisabledDate, @Latitude, @Longitude, @DateCreation)";
            //Parameters...
            SqlParameter p_idMembre = new SqlParameter("idMembre", entity.IdMembre);
            command.Parameters.Add(p_idMembre);
            SqlParameter p_titre = new SqlParameter("titre", entity.Titre);
            command.Parameters.Add(p_titre);
            SqlParameter p_DescCourte = new SqlParameter("DescCourte", entity.DescCourte);
            command.Parameters.Add(p_DescCourte);
            SqlParameter p_DescLong = new SqlParameter("DescLong", entity.DescLong);
            command.Parameters.Add(p_DescLong);
            SqlParameter p_NombrePerson = new SqlParameter("NombrePerson", entity.NombrePerson);
            command.Parameters.Add(p_NombrePerson);
            SqlParameter p_Pays = new SqlParameter("Pays", entity.Pays);
            command.Parameters.Add(p_Pays);
            SqlParameter p_Ville = new SqlParameter("Ville", entity.Ville);
            command.Parameters.Add(p_Ville);
            SqlParameter p_Rue = new SqlParameter("Rue", entity.Rue);
            command.Parameters.Add(p_Rue);
            SqlParameter p_Numero = new SqlParameter("Numero", entity.Numero);
            command.Parameters.Add(p_Numero);
            SqlParameter p_CodePostal = new SqlParameter("CodePostal", entity.CodePostal);
            command.Parameters.Add(p_CodePostal);
            SqlParameter p_Photo = new SqlParameter("Photo", entity.Photo);
            command.Parameters.Add(p_Photo);
            SqlParameter p_AssuranceObligatoire = new SqlParameter("AssuranceObligatoire", entity.AssuranceObligatoire);
            command.Parameters.Add(p_AssuranceObligatoire);
            SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.IsEnabled);
            command.Parameters.Add(p_isEnabled);
            SqlParameter p_DisabledDate = new SqlParameter("DisabledDate", entity.DisabledDate);
            command.Parameters.Add(p_DisabledDate);
            SqlParameter p_Latitude = new SqlParameter("Latitude", entity.Latitude);
            command.Parameters.Add(p_Latitude);
            SqlParameter p_Longitude = new SqlParameter("Longitude", entity.Longitude);
            command.Parameters.Add(p_Longitude);
            SqlParameter p_DateCreation = new SqlParameter("DateCreation", entity.DateCreation);
            command.Parameters.Add(p_DateCreation);
            connection.Open();
            //Choose Execution method
            return (int)command.ExecuteScalar();
        }
        public void Update(int idBien, BienEchange entity)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE[dbo].[BienEchange] SET [titre] = @titre,[DescCourte] = @DescCourte,[DescLong] = @DescLong, [NombrePerson] = @NombrePerson, [Pays] = @Pays,[Ville] = @Ville, [Rue] = @Rue, [Numero]= @Numero, [CodePostal] = @CodePostal, [Photo] = @Photo, [AssuranceObligatoire] = @AssuranceObligatoire, [isEnabled] = @isEnabled, [DisabledDate] = @DisabledDate, [Latitude] = @Latitude, [Longitude] = @Longitude,[DateCreation] = @DateCreation WHERE [idBien] = @idBien";
            SqlParameter p_titre = new SqlParameter("titre", entity.Titre);
            command.Parameters.Add(p_titre);
            SqlParameter p_DescCourte = new SqlParameter("DescCourte", entity.DescCourte);
            command.Parameters.Add(p_DescCourte);
            SqlParameter p_DescLong = new SqlParameter("DescLong", entity.DescLong);
            command.Parameters.Add(p_DescLong);
            SqlParameter p_NombrePerson = new SqlParameter("NombrePerson", entity.NombrePerson);
            command.Parameters.Add(p_NombrePerson);
            SqlParameter p_Pays = new SqlParameter("Pays", entity.Pays);
            command.Parameters.Add(p_Pays);
            SqlParameter p_Ville = new SqlParameter("Ville", entity.Ville);
            command.Parameters.Add(p_Ville);
            SqlParameter p_Rue = new SqlParameter("Rue", entity.Rue);
            command.Parameters.Add(p_Rue);
            SqlParameter p_Numero = new SqlParameter("Numero", entity.Numero);
            command.Parameters.Add(p_Numero);
            SqlParameter p_CodePostal = new SqlParameter("CodePostal", entity.CodePostal);
            command.Parameters.Add(p_CodePostal);
            SqlParameter p_Photo = new SqlParameter("Photo", entity.Photo);
            command.Parameters.Add(p_Photo);
            SqlParameter p_AssuranceObligatoire = new SqlParameter("AssuranceObligatoire", entity.AssuranceObligatoire);
            command.Parameters.Add(p_AssuranceObligatoire);
            SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.IsEnabled);
            command.Parameters.Add(p_isEnabled);
            SqlParameter p_DisabledDate = new SqlParameter("DisabledDate", entity.DisabledDate);
            command.Parameters.Add(p_DisabledDate);
            SqlParameter p_Latitude = new SqlParameter("Latitude", entity.Latitude);
            command.Parameters.Add(p_Latitude);
            SqlParameter p_Longitude = new SqlParameter("Longitude", entity.Longitude);
            command.Parameters.Add(p_Longitude);
            SqlParameter p_DateCreation = new SqlParameter("DateCreation", entity.DateCreation);
            command.Parameters.Add(p_DateCreation);
            SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = idBien };
            command.Parameters.Add(p_idBien);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

}
