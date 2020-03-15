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
        Planet planet;
        IInfoRepository repo;

        public SpeciesController(IInfoRepository r)
        {
            repo = r;
        }

        // GET: Species
        [ValidateAntiForgeryToken]
        public ViewResult Species()
        {
            List<Species> species = repo.SWSpecies;
            return View(species);
        }

        [ValidateAntiForgeryToken]
        public ViewResult ViewSpecies(string speciesName)
        {
            species = repo.GetSpeciesBySpeciesName(speciesName);
            return View(species);
        }

        // GET: Planets/
        [ValidateAntiForgeryToken]
        public ViewResult Planet()
        {
            List<Planet> planets = repo.Planets;
            return View(planets);
        }

        [ValidateAntiForgeryToken]
        public ViewResult ViewPlanet(string planetName)
        {
            planet = repo.GetPlanetByName(planetName);
            return View(planet);
        }
    }
}