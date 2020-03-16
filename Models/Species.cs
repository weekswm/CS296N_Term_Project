using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS296N_Term_Project.Models
{
    public class Species
    {
        private List<Species> speciesList = new List<Species>();

        public int SpeciesID { get; set; }
        public string SpeciesName { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        public Nullable<int> AvgHeight { get; set; }
        public string Language { get; set; }
        public Nullable<int> AvgLifeSpan { get; set; }
        public string Homeworld { get; set; }
        public object Viewbag { get; }

        public List<Species> SWSpecies { get { return speciesList; } }
    }
}
