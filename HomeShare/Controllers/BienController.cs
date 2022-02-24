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
        
        //action pour récupérer la listes des biens
        public IActionResult Index()
        {
            IEnumerable<BienEchangeListItem> model = _bienEchangeService.Get().Select(c => c.ToListItem());
            model = model.Select(p => { p.PaysP = _paysService.Get((int)p.Pays).ToDetails(); return p; });
            return View(model);
        }

        //action pour récupérer le détail d'un bien
        public IActionResult Details(int id)
        {
            BienEchangeDetails model = _bienEchangeService.Get(id).ToDetails();
            model.PaysP = _paysService.Get((int)model.Pays).ToDetails();
            return View(model);
        }

        //La prochaine étape est d'ajouter un IActionResult pour créer un nouveau bien via le link "create new"!!!
        //To be continue...
    }
}
