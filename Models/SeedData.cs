using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CS296N_Term_Project.Models
{
    public class SeedData
    {
        public static void Seed(AppIdentityDbContext context)
        {
            // add Species data
            if (!context.SWSpecies.Any()) // only do this if it hasn't been done already
            {
                Species species = new Species()
                {
                    SpeciesName = "Wookiee",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 210,
                    Language = "Shyriiwook",
                    AvgLifeSpan = 400,
                    Homeworld = "Kashyyyk"
                };
                context.SWSpecies.Add(species);
                Species species2 = new Species()
                {
                    SpeciesName = "Hutt",
                    Classification = "gastropod",
                    Designation = "sentient",
                    AvgHeight = 300,
                    Language = "Huttese",
                    AvgLifeSpan = 1000,
                    Homeworld = "Nal Hutta"
                };
                context.SWSpecies.Add(species2);
                Species species3 = new Species()
                {
                    SpeciesName = "Yoda's species",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 66,
                    Language = "Galactic basic",
                    AvgLifeSpan = 900,
                    Homeworld = "Unknown"
                };
                context.SWSpecies.Add(species3);
                Species species4 = new Species()
                {
                    SpeciesName = "Trandoshan",
                    Classification = "reptile",
                    Designation = "sentient",
                    AvgHeight = 200,
                    Language = "Dosh",
                    AvgLifeSpan = null,
                    Homeworld = "Trandosha"
                };
                context.SWSpecies.Add(species4);
                Species species5 = new Species()
                {
                    SpeciesName = "Mon Calamari",
                    Classification = "amphibian",
                    Designation = "sentient",
                    AvgHeight = 160,
                    Language = "Mon Calamarian",
                    AvgLifeSpan = null,
                    Homeworld = "Mon Cala"
                };
                context.SWSpecies.Add(species5);
                Species species6 = new Species()
                {
                    SpeciesName = "Ewok",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 100,
                    Language = "Ewokese",
                    AvgLifeSpan = null,
                    Homeworld = "Endor"
                };
                context.SWSpecies.Add(species6);
                Species species7 = new Species()
                {
                    SpeciesName = "Sullustan",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Sullutese",
                    AvgLifeSpan = null,
                    Homeworld = "Sullust"
                };
                context.SWSpecies.Add(species7);
                Species species8 = new Species()
                {
                    SpeciesName = "Neimodian",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Neimoidia",
                    AvgLifeSpan = null,
                    Homeworld = "Cato Neimoidia"
                };
                context.SWSpecies.Add(species8);
                Species species9 = new Species()
                {
                    SpeciesName = "Gungan",
                    Classification = "amphibian",
                    Designation = "sentient",
                    AvgHeight = 190,
                    Language = "Gungan basic",
                    AvgLifeSpan = null,
                    Homeworld = "Naboo"
                };
                context.SWSpecies.Add(species9);
                Species species10 = new Species()
                {
                    SpeciesName = "Toydarian",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 120,
                    Language = "Toydarian",
                    AvgLifeSpan = 91,
                    Homeworld = "Toydaria"
                };
                context.SWSpecies.Add(species10);
                Species species11 = new Species()
                {
                    SpeciesName = "Dug",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 100,
                    Language = "Dugese",
                    AvgLifeSpan = null,
                    Homeworld = "Malastare"
                };
                context.SWSpecies.Add(species11);
                Species species12 = new Species()
                {
                    SpeciesName = "Kel Dor",
                    Classification = "Unclassified",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Kel Dor",
                    AvgLifeSpan = 400,
                    Homeworld = "Dorin"
                };
                context.SWSpecies.Add(species12);
                Species species13 = new Species()
                {
                    SpeciesName = "Twi'lek",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 200,
                    Language = "Twi'leki",
                    AvgLifeSpan = null,
                    Homeworld = "Ryloth"
                };
                context.SWSpecies.Add(species13);
                Species species14 = new Species()
                {
                    SpeciesName = "Aleena",
                    Classification = "reptile",
                    Designation = "sentient",
                    AvgHeight = 80,
                    Language = "Aleena",
                    AvgLifeSpan = 79,
                    Homeworld = "Aleen Minor"
                };
                context.SWSpecies.Add(species14);
                Species species15 = new Species()
                {
                    SpeciesName = "Quermian",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 240,
                    Language = "Quermian",
                    AvgLifeSpan = 86,
                    Homeworld = "Quermia"
                };
                context.SWSpecies.Add(species15);
                Species species16 = new Species()
                {
                    SpeciesName = "Vulptereen",
                    Classification = "Unclassified",
                    Designation = "sentient",
                    AvgHeight = 100,
                    Language = "Vulpterish",
                    AvgLifeSpan = null,
                    Homeworld = "Vulpter"
                };
                context.SWSpecies.Add(species16);
                Species species17 = new Species()
                {
                    SpeciesName = "Iktotchi",
                    Classification = "Unclassified",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Iktotchese",
                    AvgLifeSpan = null,
                    Homeworld = "Iktotch"
                };
                context.SWSpecies.Add(species17);
                Species species18 = new Species()
                {
                    SpeciesName = "Xexto",
                    Classification = "Unclassified",
                    Designation = "sentient",
                    AvgHeight = 125,
                    Language = "Xextese",
                    AvgLifeSpan = null,
                    Homeworld = "Troiken"
                };
                context.SWSpecies.Add(species18);
                Species species19 = new Species()
                {
                    SpeciesName = "Cerean",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 200,
                    Language = "Cerean",
                    AvgLifeSpan = null,
                    Homeworld = "Cerea"
                };
                context.SWSpecies.Add(species19);
                Species species20 = new Species()
                {
                    SpeciesName = "Toong",
                    Classification = "Unclassified",
                    Designation = "sentient",
                    AvgHeight = 200,
                    Language = "Tundan",
                    AvgLifeSpan = 400,
                    Homeworld = "Tund"
                };
                context.SWSpecies.Add(species20);
                Species species21 = new Species()
                {
                    SpeciesName = "Nautolan",
                    Classification = "amphibian",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Nautila",
                    AvgLifeSpan = 70,
                    Homeworld = "Glee Anselm"
                };
                context.SWSpecies.Add(species21);
                Species species22 = new Species()
                {
                    SpeciesName = "Zabrak",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Zabraki",
                    AvgLifeSpan = null,
                    Homeworld = "Iridonia"
                };
                context.SWSpecies.Add(species22);
                Species species23 = new Species()
                {
                    SpeciesName = "Tholothian",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = null,
                    Language = "Unknown",
                    AvgLifeSpan = null,
                    Homeworld = "Tholoth"
                };
                context.SWSpecies.Add(species23);
                Species species24 = new Species()
                {
                    SpeciesName = "Chagrian",
                    Classification = "amphibian",
                    Designation = "sentient",
                    AvgHeight = 190,
                    Language = "Chagria",
                    AvgLifeSpan = null,
                    Homeworld = "Champala"
                };
                context.SWSpecies.Add(species24);
                Species species25 = new Species()
                {
                    SpeciesName = "Geonosian",
                    Classification = "insectoid",
                    Designation = "sentient",
                    AvgHeight = 178,
                    Language = "Geonosian",
                    AvgLifeSpan = null,
                    Homeworld = "Geonosis"
                };
                context.SWSpecies.Add(species25);
                Species species26 = new Species()
                {
                    SpeciesName = "Mirialan",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Mirialan",
                    AvgLifeSpan = null,
                    Homeworld = "Mirial"
                };
                context.SWSpecies.Add(species26);
                Species species27 = new Species()
                {
                    SpeciesName = "Clawdite",
                    Classification = "reptilian",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Clawdite",
                    AvgLifeSpan = 70,
                    Homeworld = "Zolan"
                };
                context.SWSpecies.Add(species27);
                Species species28 = new Species()
                {
                    SpeciesName = "Besalisk",
                    Classification = "amphibian",
                    Designation = "sentient",
                    AvgHeight = 178,
                    Language = "Besalisk",
                    AvgLifeSpan = 75,
                    Homeworld = "Ojom"
                };
                context.SWSpecies.Add(species28);
                Species species29 = new Species()
                {
                    SpeciesName = "Kaminoan",
                    Classification = "amphibian",
                    Designation = "sentient",
                    AvgHeight = 220,
                    Language = "Kaminoan",
                    AvgLifeSpan = 80,
                    Homeworld = "Kamino"
                };
                context.SWSpecies.Add(species29);
                Species species30 = new Species()
                {
                    SpeciesName = "Skakoan",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = null,
                    Language = "Skakoan",
                    AvgLifeSpan = null,
                    Homeworld = "Skako"
                };
                context.SWSpecies.Add(species30);
                Species species31 = new Species()
                {
                    SpeciesName = "Muun",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 190,
                    Language = "Muun",
                    AvgLifeSpan = 100,
                    Homeworld = "Muunilinst"
                };
                context.SWSpecies.Add(species31);
                Species species32 = new Species()
                {
                    SpeciesName = "Togruta",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Togruti",
                    AvgLifeSpan = 94,
                    Homeworld = "Shili"
                };
                context.SWSpecies.Add(species32);
                Species species33 = new Species()
                {
                    SpeciesName = "Kaleesh",
                    Classification = "reptile",
                    Designation = "sentient",
                    AvgHeight = 170,
                    Language = "Kaleesh",
                    AvgLifeSpan = 80,
                    Homeworld = "Kalee"
                };
                context.SWSpecies.Add(species33);
                Species species34 = new Species()
                {
                    SpeciesName = "Pau'an",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 190,
                    Language = "Utapese",
                    AvgLifeSpan = 700,
                    Homeworld = "Utapau"
                };
                context.SWSpecies.Add(species34);
                Species species35 = new Species()
                {
                    SpeciesName = "Human",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 180,
                    Language = "Galactic Basic",
                    AvgLifeSpan = 120,
                    Homeworld = "Coruscant"
                };
                context.SWSpecies.Add(species35);
                Species species36 = new Species()
                {
                    SpeciesName = "Droid",
                    Classification = "artificial",
                    Designation = "sentient",
                    AvgHeight = null,
                    Language = "N/A",
                    AvgLifeSpan = null,
                    Homeworld = "N/A"
                };
                context.SWSpecies.Add(species36);
                Species species37 = new Species()
                {
                    SpeciesName = "Rodian",
                    Classification = "reptilian",
                    Designation = "sentient",
                    AvgHeight = 170,
                    Language = "Galactic Basic",
                    AvgLifeSpan = null,
                    Homeworld = "Rodia"
                };
                context.SWSpecies.Add(species37);
            }

            // add Planet data
            if (!context.Planets.Any()) // only do this if it hasn't been done already
            {
                Planet planet = new Planet()
                {
                    PlanetName = "Alderaan",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 364,
                    Diameter = 12500,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet);
                Planet planet2 = new Planet()
                {
                    PlanetName = "Yavin_IV",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 4818,
                    Diameter = 10200,
                    Climate = "temperate, Tropical",
                    Gravity = 1
                };
                context.Planets.Add(planet2);
                Planet planet3 = new Planet()
                {
                    PlanetName = "Hoth",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 549,
                    Diameter = 7200,
                    Climate = "frozen",
                    Gravity = 1.1
                };
                context.Planets.Add(planet3);
                Planet planet4 = new Planet()
                {
                    PlanetName = "Dagobah",
                    RotationalPeriod = 23,
                    OrbitalPeriod = 341,
                    Diameter = 8900,
                    Climate = "murky",
                    Gravity = null
                };
                context.Planets.Add(planet4);
                Planet planet5 = new Planet()
                {
                    PlanetName = "Bespin",
                    RotationalPeriod = 12,
                    OrbitalPeriod = 5110,
                    Diameter = 118000,
                    Climate = "temperate",
                    Gravity = 1.5
                };
                context.Planets.Add(planet5);
                Planet planet6 = new Planet()
                {
                    PlanetName = "Endor",
                    RotationalPeriod = 18,
                    OrbitalPeriod = 402,
                    Diameter = 4900,
                    Climate = "temperate",
                    Gravity = 0.85
                };
                context.Planets.Add(planet6);
                Planet planet7 = new Planet()
                {
                    PlanetName = "Naboo",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 312,
                    Diameter = 12120,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet7);
                Planet planet8 = new Planet()
                {
                    PlanetName = "Coruscant",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 368,
                    Diameter = 12240,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet8);
                Planet planet9 = new Planet()
                {
                    PlanetName = "Kamino",
                    RotationalPeriod = 27,
                    OrbitalPeriod = 463,
                    Diameter = 19720,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet9);
                Planet planet10 = new Planet()
                {
                    PlanetName = "Geonosis",
                    RotationalPeriod = 30,
                    OrbitalPeriod = 265,
                    Diameter = 11370,
                    Climate = "temperate, arid",
                    Gravity = 0.9
                };
                context.Planets.Add(planet10);
                Planet planet11 = new Planet()
                {
                    PlanetName = "Utapau",
                    RotationalPeriod = 27,
                    OrbitalPeriod = 351,
                    Diameter = 12900,
                    Climate = "temperate, arid, windy",
                    Gravity = 1
                };
                context.Planets.Add(planet11);
                Planet planet12 = new Planet()
                {
                    PlanetName = "Mustafar",
                    RotationalPeriod = 36,
                    OrbitalPeriod = 412,
                    Diameter = 4200,
                    Climate = "hot",
                    Gravity = 1
                };
                context.Planets.Add(planet12);
                Planet planet13 = new Planet()
                {
                    PlanetName = "Kashyyyk",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 381,
                    Diameter = 12765,
                    Climate = "tropical",
                    Gravity = 1
                };
                context.Planets.Add(planet13);
                Planet planet14 = new Planet()
                {
                    PlanetName = "Polis_Massa",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 590,
                    Diameter = null,
                    Climate = "artificial temperate",
                    Gravity = 0.56
                };
                context.Planets.Add(planet14);
                Planet planet15 = new Planet()
                {
                    PlanetName = "Mygeeto",
                    RotationalPeriod = 12,
                    OrbitalPeriod = 167,
                    Diameter = 10088,
                    Climate = "frigid",
                    Gravity = 1
                };
                context.Planets.Add(planet15);
                Planet planet16 = new Planet()
                {
                    PlanetName = "Felucia",
                    RotationalPeriod = 34,
                    OrbitalPeriod = 231,
                    Diameter = 9100,
                    Climate = "hot, humid",
                    Gravity = 0.75
                };
                context.Planets.Add(planet16);
                Planet plane17 = new Planet()
                {
                    PlanetName = "Cato_Neimoidia",
                    RotationalPeriod = 25,
                    OrbitalPeriod = 278,
                    Diameter = null,
                    Climate = "temperate, moist",
                    Gravity = 1
                };
                context.Planets.Add(plane17);
                Planet planet18 = new Planet()
                {
                    PlanetName = "Saleucami",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 392,
                    Diameter = 14920,
                    Climate = "hot",
                    Gravity = null
                };
                context.Planets.Add(planet18);
                Planet planet19 = new Planet()
                {
                    PlanetName = "Stewjon",
                    RotationalPeriod = null,
                    OrbitalPeriod = null,
                    Diameter = null,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet19);
                Planet planet20 = new Planet()
                {
                    PlanetName = "Eriadu",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 360,
                    Diameter = 13490,
                    Climate = "polluted",
                    Gravity = 1
                };
                context.Planets.Add(planet20);
                Planet planet21 = new Planet()
                {
                    PlanetName = "Corellia",
                    RotationalPeriod = 25,
                    OrbitalPeriod = 329,
                    Diameter = 11000,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet21);
                Planet planet22 = new Planet()
                {
                    PlanetName = "Rodia",
                    RotationalPeriod = 29,
                    OrbitalPeriod = 305,
                    Diameter = 7549,
                    Climate = "hot",
                    Gravity = 1
                };
                context.Planets.Add(planet22);
                Planet planet23 = new Planet()
                {
                    PlanetName = "Nal_Hutta",
                    RotationalPeriod = 87,
                    OrbitalPeriod = 413,
                    Diameter = 12150,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet23);
                Planet planet24 = new Planet()
                {
                    PlanetName = "Dantooine",
                    RotationalPeriod = 87,
                    OrbitalPeriod = 378,
                    Diameter = 9830,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet24);
                Planet planet25 = new Planet()
                {
                    PlanetName = "Bestine_IV",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 680,
                    Diameter = 6400,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet25);
                Planet planet26 = new Planet()
                {
                    PlanetName = "Ord_Mantell",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 680,
                    Diameter = 14050,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet26);
                Planet planet27 = new Planet()
                {
                    PlanetName = "Trandosha",
                    RotationalPeriod = 25,
                    OrbitalPeriod = 371,
                    Diameter = null,
                    Climate = "arid",
                    Gravity = 0.62
                };
                context.Planets.Add(planet27);
                Planet planet28 = new Planet()
                {
                    PlanetName = "Socorro",
                    RotationalPeriod = 20,
                    OrbitalPeriod = 326,
                    Diameter = null,
                    Climate = "arid",
                    Gravity = 1
                };
                context.Planets.Add(planet28);
                Planet planet29 = new Planet()
                {
                    PlanetName = "Mon_Cala",
                    RotationalPeriod = 21,
                    OrbitalPeriod = 398,
                    Diameter = 11030,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet29);
                Planet planet30 = new Planet()
                {
                    PlanetName = "Chandrila",
                    RotationalPeriod = 20,
                    OrbitalPeriod = 368,
                    Diameter = 13500,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet30);
                Planet planet31 = new Planet()
                {
                    PlanetName = "Sullust",
                    RotationalPeriod = 20,
                    OrbitalPeriod = 263,
                    Diameter = 12780,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet31);
                Planet planet32 = new Planet()
                {
                    PlanetName = "Toydaria",
                    RotationalPeriod = 21,
                    OrbitalPeriod = 184,
                    Diameter = 7900,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet32);
                Planet planet33 = new Planet()
                {
                    PlanetName = "Malastare",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 201,
                    Diameter = 18880,
                    Climate = "arid, temperate, tropical",
                    Gravity = 1.56
                };
                context.Planets.Add(planet33);
                Planet planet34 = new Planet()
                {
                    PlanetName = "Dathomir",
                    RotationalPeriod = 24,
                    OrbitalPeriod = 491,
                    Diameter = 10480,
                    Climate = "temperate",
                    Gravity = 0.9
                };
                context.Planets.Add(planet34);
                Planet planet35 = new Planet()
                {
                    PlanetName = "Ryloth",
                    RotationalPeriod = 30,
                    OrbitalPeriod = 305,
                    Diameter = 10600,
                    Climate = "temerate, arid, subarctic",
                    Gravity = 1
                };
                context.Planets.Add(planet35);
                Planet planet36 = new Planet()
                {
                    PlanetName = "Vulpter",
                    RotationalPeriod = 22,
                    OrbitalPeriod = 391,
                    Diameter = 14900,
                    Climate = "temperate, arctic",
                    Gravity = 1
                };
                context.Planets.Add(planet36);
                Planet plane37 = new Planet()
                {
                    PlanetName = "Tund",
                    RotationalPeriod = 48,
                    OrbitalPeriod = 1770,
                    Diameter = 12190,
                    Climate = "hostile",
                    Gravity = null
                };
                context.Planets.Add(plane37);
                Planet planet38 = new Planet()
                {
                    PlanetName = "Haruun_Kal",
                    RotationalPeriod = 25,
                    OrbitalPeriod = 383,
                    Diameter = 10120,
                    Climate = "temperate",
                    Gravity = .98
                };
                context.Planets.Add(planet38);
                Planet planet39 = new Planet()
                {
                    PlanetName = "Cerea",
                    RotationalPeriod = 27,
                    OrbitalPeriod = 386,
                    Diameter = null,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet39);
                Planet planet40 = new Planet()
                {
                    PlanetName = "Glee_Anselm",
                    RotationalPeriod = 33,
                    OrbitalPeriod = 206,
                    Diameter = 15600,
                    Climate = "tropical, temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet40);
                Planet planet41 = new Planet()
                {
                    PlanetName = "Iktotch",
                    RotationalPeriod = 22,
                    OrbitalPeriod = 481,
                    Diameter = null,
                    Climate = "arid, rocky, windy",
                    Gravity = 1
                };
                context.Planets.Add(planet41);
                Planet planet42 = new Planet()
                {
                    PlanetName = "Glee_Dorin",
                    RotationalPeriod = 22,
                    OrbitalPeriod = 409,
                    Diameter = 13400,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet42);
                Planet planet43 = new Planet()
                {
                    PlanetName = "Champala",
                    RotationalPeriod = 27,
                    OrbitalPeriod = 318,
                    Diameter = null,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet43);
                Planet planet44 = new Planet()
                {
                    PlanetName = "Skako",
                    RotationalPeriod = 27,
                    OrbitalPeriod = 384,
                    Diameter = null,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet44);
                Planet planet45 = new Planet()
                {
                    PlanetName = "Muunilinst",
                    RotationalPeriod = 28,
                    OrbitalPeriod = 412,
                    Diameter = 13800,
                    Climate = "temperate",
                    Gravity = 1
                };
                context.Planets.Add(planet45);
                Planet planet46 = new Planet()
                {
                    PlanetName = "Kalee",
                    RotationalPeriod = 23,
                    OrbitalPeriod = 378,
                    Diameter = 13850,
                    Climate = "arid, temperate, tropical",
                    Gravity = 1
                };
                context.Planets.Add(planet46);
                Planet planet47 = new Planet()
                {
                    PlanetName = "Tatooine",
                    RotationalPeriod = 23,
                    OrbitalPeriod = 304,
                    Diameter = 10465,
                    Climate = "arid",
                    Gravity = 1
                };
                context.Planets.Add(planet47);

                // add Stories and Comments
                if (!context.FanStories.Any())
                {
                    // story 1, fan 1

                    FanStory fanStory1 = new FanStory()
                    {
                        Name = "Rebel4Life",
                        StoryText = "Never tell me the odds..."
                    };
                    context.FanStories.Add(fanStory1);

                    // story 2, fan 2
                    FanStory fanStory2 = new FanStory()
                    {
                        Name = "LukesDad",
                        StoryText = "I'm not sure people didn't see that coming - Vader is the German word for father!"
                    };

                    // new comment from user
                    Comment comment = new Comment()
                    {
                        CommentText = "I can't believe I missed that.",
                        Commenter = "Mrs. Solo",
                    };
                    // Adding comment to story 2
                    context.Comments.Add(comment);
                    fanStory2.Comments.Add(comment);
                    context.FanStories.Add(fanStory2);


                    // story 3, fan 3
                    FanStory fanStory3 = new FanStory()
                    {
                        Name = "ScruffyLookingNerfHerder",
                        StoryText = "So this one time I got frozen alive in carbonite..."
                    };
                    context.FanStories.Add(fanStory3);
                }
                context.SaveChanges(); // save all the data
            }
        }
    }
}
