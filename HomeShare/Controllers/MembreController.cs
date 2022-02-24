using HolidayRental.BLL.Entities;
using HolidayRental.Common.Repositories;
using HoliDayRental.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Controllers
{
    public class MembreController : Controller
    {
        private readonly IMembreRepository<Membre> _membreService;
        public MembreController(IMembreRepository<Membre> membreService)
        {
            _membreService = membreService;
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MembreCreateForm collection)
        {
            try
            {
               if (!ModelState.IsValid) throw new Exception();
                Membre result = new()
                {
                    Prenom = collection.Prenom,
                    Nom = collection.Nom,
                    Email = collection.Email,
                    Pays = collection.Pays,
                    Telephone = collection.Telephone,
                    Login = collection.Prenom[0] + collection.Nom,
                    Password = collection.Password
                };
                this._membreService.Insert(result);
                return View("Confirmation");
                //idéalement faire un redirecttoaction vers l'index mais vu que je n'ai pas "d'ActionResult Index", je laisse le return vers la view.
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View(collection);
            }
        }

    }
}
