using HolidayRental.Common.Repositories;
using HolidayRental.DAL.Entities;
using HolidayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HolidayRental.DAL.Repositories
{
    public class PaysService : ServiceBase, IPaysRepository<Pays>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pays Get(int id)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idPays],[Libelle] FROM [dbo].[Pays] WHERE [idPays] = @id";
            SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
            command.Parameters.Add(p_id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) return Mapper.ToPays(reader);
            return null;
        }

        public IEnumerable<Pays> Get()
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idPays],[Libelle] FROM [dbo].[Pays]";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) yield return Mapper.ToPays(reader);
        }

        public int Insert(Pays entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Pays entity)
        {
            throw new NotImplementedException();
        }
    }
}
