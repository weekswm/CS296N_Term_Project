using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CS296N_Term_Project.Models;
using CS296N_Term_Project.Repostories;

namespace CS296N_Term_Project.Controllers
{
    public class SpeciesController : Controller
    {
        Species species;
        IInfoRepository repo;
        public SpeciesController(IInfoRepository r)
        {
            repo = r;
        }
        // GET: Species
        public ViewResult Species()
        {
            List<Species> species = repo.SWSpecies;
            return View(species);
        }

        public ViewResult ViewSpecies(string speciesName)
        {
            species = repo.GetSpeciesBySpeciesName(speciesName);
            return View(species);
        }

        public ViewResult Planet()
        {
            List<Planet> planets = repo.Planets;
            return View(planets);
        }

        // GET: Species/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Species/Create
        public ActionResult AddSpecies()
        {
            return View();
        }

        // POST: Species/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSpecies(IQueryable<> collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Species/Edit/5
        public ActionResult EditSpecies(int id)
        {
            return View();
        }

        // POST: Species/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSpecies(int id, IQueryable<> collection)
        {

        }

        // GET: Species/Edit/5
        public ActionResult ReplaceSpecies(int id)
        {
            return View();
        }

        // POST: Species/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReplaceSpecies(int id, IQueryable<> collection)
        {

        }

        // GET: Species/Delete/5
        public ActionResult DeleteSpecies(int id)
        {
            return View();
        }

        // POST: Species/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSpecies(int id, IQueryable<> collection)
        {
            
        }
    }
}