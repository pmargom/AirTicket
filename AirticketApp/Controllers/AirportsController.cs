using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirticketApp.Controllers.Api;
using AirticketApp.Models;
using AirticketApp.ViewModels;
using AutoMapper;

namespace AirticketApp.Controllers
{
    public class AirportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirportsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var viewModel = new AirportFormViewModel()
            {
                Airport = new Airport()
            };

            return View("AirportForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Airport airport)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new AirportFormViewModel()
                {
                    Airport = airport,
                };

                return View("AirportForm", viewModel);
            }

            if (airport.Id == 0)
                _context.Airports.Add(airport);
            else
            {
                var airportInDb = _context.Airports.Single(c => c.Id == airport.Id);

                Mapper.Map(airport, airportInDb);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Airports");
        }

        public ViewResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var airport = _context.Airports.SingleOrDefault(p => p.Id == id);

            if (airport == null)
                return HttpNotFound();

            return View(airport);
        }

        public ActionResult Edit(int id)
        {
            var airport = _context.Airports.SingleOrDefault(c => c.Id == id);

            if (airport == null)
                return HttpNotFound();

            var viewModel = new AirportFormViewModel
            {
                Airport = airport
            };

            return View("AirportForm", viewModel);
        }
    }
}