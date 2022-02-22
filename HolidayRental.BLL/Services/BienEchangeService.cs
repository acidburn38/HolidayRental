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
    public class BienEchangeService : IBienEchangeRepository<BienEchange>
    {
        private readonly IBienEchangeRepository<DAL.Entities.BienEchange> _bienEchangeRepository;

        public BienEchangeService(IBienEchangeRepository<DAL.Entities.BienEchange> repository)
        {
            _bienEchangeRepository = repository;
        }
        public void Delete(int idBien)
        {
            _bienEchangeRepository.Delete(idBien);
        }

        public BienEchange Get(int idBien)
        {
            return _bienEchangeRepository.Get(idBien).ToBLL();
        }

        public IEnumerable<BienEchange> Get()
        {
            return _bienEchangeRepository.Get().Select(c => c.ToBLL());
        }

        public int Insert(BienEchange entity)
        {
            return _bienEchangeRepository.Insert(entity.ToDAL());
        }

        public void Update(int idBien, BienEchange entity)
        {
            _bienEchangeRepository.Update(idBien, entity.ToDAL());
        }
    }
}
