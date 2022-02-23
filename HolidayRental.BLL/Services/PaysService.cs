using HolidayRental.BLL.Entities;
using HolidayRental.BLL.Handlers;
using HolidayRental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.BLL.Services
{
    public class PaysService : IPaysRepository<Pays>
    {
        private readonly IPaysRepository<DAL.Entities.Pays> _paysRepository;

        public PaysService(IPaysRepository<DAL.Entities.Pays> repository)
        {
            _paysRepository = repository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pays Get(int idBien)
        {
            return _paysRepository.Get(idBien).ToBLL();
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
