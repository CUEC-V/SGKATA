using Microsoft.EntityFrameworkCore;
using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.DEPOT
{
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(SGDbContext context) : base(context) { }

        public List<Recipe> GetAll(string nomRecette = "")
        {
            var recettes = Context.Set<Recipe>()
                .Include(a => a.Ingredients)
                .ToList();

            if (!string.IsNullOrEmpty(nomRecette))
            {
                nomRecette = nomRecette.ToUpper();

                recettes = recettes
                    .Where(r => r.Name.ToUpper().Contains(nomRecette))
                    .ToList();
            }

            return recettes;
        }
    }
}
