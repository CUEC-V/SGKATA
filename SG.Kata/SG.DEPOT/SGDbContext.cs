using Microsoft.EntityFrameworkCore;
using SG.REPOSITORY.Parameter;
using SG.ENTITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SG.REPOSITORY
{
    public class SGDbContext : DbContext
    {
        public SGDbContext(DbContextOptions<SGDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipe { get; set; }

        public DbSet<Ingredient> Ingredient { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SGConfiguration.ConnectingString);
        }
    }
}
