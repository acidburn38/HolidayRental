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

        public Pays Get(int idBien)
        {
            using SqlConnection connection = new SqlConnection(_connString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [idPays],[Libelle] FROM [Pays] WHERE [idPays] = @idBien";
            SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = idBien };
            command.Parameters.Add(p_idBien);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) return Mapper.ToPays(reader);
            return null;
        }

        public IEnumerable<Pays> Get()
        {
            throw new NotImplementedException();
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
