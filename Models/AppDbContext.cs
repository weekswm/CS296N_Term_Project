using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CS296N_Term_Project.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Species> SWSpecies { get; set; }
        public DbSet<Planet> Planets { get; set; }
    }
}
