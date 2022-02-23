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

        public BienController(IBienEchangeRepository<BienEchange> bienEchangeService)
        {
            _bienEchangeService = bienEchangeService;
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
