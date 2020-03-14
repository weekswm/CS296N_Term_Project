using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS296N_Term_Project.Models;

namespace CS296N_Term_Project.Repostories
{
    public class InfoRepository : IInfoRepository
    {
        private AppDbContext context;
        public InfoRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        private List<Planet> planets = new List<Planet>();

        public List<Planet> Planets { get { return context.Planets.ToList(); } }
        public void AddPlanet(Planet planet)
        {
            context.Planets.Add(planet);
            context.SaveChanges();
        }

        public Planet GetPlanetByName(string name)
        {
            Planet planet = planets.Find(p => p.PlanetName == name);
            return planet;
        }

        //private List<Species> speciesList = new List<Species>();

        public List<Species> SWSpecies { get { return context.SWSpecies.ToList(); } }
        public void AddSpecies(Species species)
        {
            context.SWSpecies.Add(species);
            context.SaveChanges();
        }
        public Species GetSpeciesBySpeciesName(string speciesName)
        {
            Species species = context.SWSpecies.ToList().Find(s => s.SpeciesName == speciesName);
            return species;
        }
    }
}
