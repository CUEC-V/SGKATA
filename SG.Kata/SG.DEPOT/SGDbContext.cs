using Microsoft.EntityFrameworkCore;
using SG.DEPOT.Parametre;
using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SG.DEPOT
{
    public class SGDbContext : DbContext
    {
        public SGDbContext(DbContextOptions<SGDbContext> options) : base(options) { }

        public DbSet<Recette> Recette { get; set; }

        public DbSet<Ingredient> Ingredient { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SGConfiguration.ConnectingString);
        }
    }
}
