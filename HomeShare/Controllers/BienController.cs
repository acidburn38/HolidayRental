using HoliDayRental.Models;
using HoliDayRental.Handlers;
using HolidayRental.BLL.Entities;
using HolidayRental.Common.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Controllers
{
    public class BienController : Controller
    {
        private readonly IBienEchangeRepository<BienEchange> _bienEchangeService;
        private readonly IPaysRepository<Pays> _paysService;

        public BienController(IBienEchangeRepository<BienEchange> bienEchangeService,
            IPaysRepository<Pays> paysService)
        {
            _bienEchangeService = bienEchangeService;
            _paysService = paysService;
        }
        public IActionResult Index()
        {
            IEnumerable<BienEchangeListItem> model = _bienEchangeService.Get().Select(c => c.ToListItem());
            return View(model);
        }

        public IActionResult Details(int id)
        {
            BienEchangeDetails model = _bienEchangeService.Get(id).ToDetails();
            return View(model);
        }
    }
}
