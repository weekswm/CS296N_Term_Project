using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS296N_Term_Project.Models
{
    public class Planet
    {
        private List<Planet> planets = new List<Planet>();

        public int PlanetID { get; set; }
        public string PlanetName { get; set; }
        public Nullable<int> RotationalPeriod { get; set; }
        public Nullable<int> OrbitalPeriod { get; set; }
        public Nullable<int> Diameter { get; set; }
        public string Climate { get; set; }
        public Nullable<double> Gravity { get; set; }
        public object Viewbag { get; }

        public List<Planet> Planets { get { return planets; } }
    }
}
