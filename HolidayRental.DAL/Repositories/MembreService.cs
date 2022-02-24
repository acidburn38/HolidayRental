using HolidayRental.Common.Repositories;
using HolidayRental.DAL.Entities;
using HolidayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HolidayRental.DAL.Repositories
{
    public class MembreService : ServiceBase, IMembreRepository<Membre>
    {
        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM [dbo].[Membre] WHERE [idMembre] = @id,";
            SqlParameter p_idBien = new SqlParameter() { ParameterName = "id", Value = id };
            command.Parameters.Add(p_idBien);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public Membre Get(int id)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM[dbo].[Membre] WHERE [idMembre] = @id";
            SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
            command.Parameters.Add(p_id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) return Mapper.ToMembre(reader);
            return null;
        }

        public IEnumerable<Membre> Get()
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM[dbo].[Membre]";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) yield return Mapper.ToMembre(reader);
        }

        public int Insert(Membre entity)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[Membre] 
            ([Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password]) OUTPUT [inserted].[idMembre]
            VALUES
            (@Nom, @Prenom, @Email, @Pays, @Telephone, @Login, @Password)";
            SqlParameter p_Nom = new SqlParameter("Nom", entity.Nom);
            command.Parameters.Add(p_Nom);
            SqlParameter p_Prenom = new SqlParameter("Prenom", entity.Prenom);
            command.Parameters.Add(p_Prenom);
            SqlParameter p_Email = new SqlParameter("Email", entity.Email);
            command.Parameters.Add(p_Email);
            SqlParameter p_Telephone = new SqlParameter("Telephone", entity.Telephone);
            command.Parameters.Add(p_Telephone);
            SqlParameter p_Login = new SqlParameter("Login", entity.Login);
            command.Parameters.Add(p_Login);
            SqlParameter p_Password = new SqlParameter("Password", entity.Password);
            command.Parameters.Add(p_Password);
            connection.Open();
            return (int)command.ExecuteScalar();
        }

        public void Update(int id, Membre entity)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = @"UPDATE [dbo].[Membre] SET [Nom] = @Nom, [Prenom] = @Prenom, [Email] = @Email, [Pays] = @Pays, [Telephone] = @Telephone, [Login] = @Login, [Password] = @Password WHERE [idMembre] = @id";
            SqlParameter p_Nom = new SqlParameter("Nom", entity.Nom);
            command.Parameters.Add(p_Nom);
            SqlParameter p_Prenom = new SqlParameter("Prenom", entity.Prenom);
            command.Parameters.Add(p_Prenom);
            SqlParameter p_Email = new SqlParameter("Email", entity.Email);
            command.Parameters.Add(p_Email);
            SqlParameter p_Telephone = new SqlParameter("Telephone", entity.Telephone);
            command.Parameters.Add(p_Telephone);
            SqlParameter p_Login = new SqlParameter("Login", entity.Login);
            command.Parameters.Add(p_Login);
            SqlParameter p_Password = new SqlParameter("Password", entity.Password);
            command.Parameters.Add(p_Password);
            SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
            command.Parameters.Add(p_id);
            connection.Open();
            command.ExecuteNonQuery(); ;
        }
    }
}
