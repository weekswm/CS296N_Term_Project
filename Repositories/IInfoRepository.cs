using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS296N_Term_Project.Models;

namespace CS296N_Term_Project.Repositories
{
    public interface IInfoRepository
    {
        List<Species> SWSpecies { get; }
        void AddSpecies(Species species);
        Species GetSpeciesBySpeciesName(string speciesName);

        List<Planet> Planets { get; }
        void AddPlanet(Planet planet);
        Planet GetPlanetByName(string planetName);
    }
}
