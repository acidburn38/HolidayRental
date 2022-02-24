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
            _paysRepository.Delete(id);
        }

        public Pays Get(int id)
        {
            return _paysRepository.Get(id).ToBLL();
        }

        public IEnumerable<Pays> Get()
        {
            return _paysRepository.Get().Select(pays => pays.ToBLL());
        }

        public int Insert(Pays entity)
        {
            return _paysRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Pays entity)
        {
            _paysRepository.Update(id, entity.ToDAL());
        }
    }
}
