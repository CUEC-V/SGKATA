using Microsoft.EntityFrameworkCore;
using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.DEPOT
{
    public class IngredientDepot : Repository<Ingredient>, IIngredientDepot
    {
        public IngredientDepot(SGDbContext context) : base(context) { }

        public List<Ingredient> GetAll(string nomIngredient = "")
        {
            var ingredients = Context.Set<Ingredient>()
                .Include(a => a.Recette)
                .ToList();

            if (!string.IsNullOrEmpty(nomIngredient))
            {
                nomIngredient = nomIngredient.ToUpper();

                ingredients = ingredients
                    .Where(r => r.Nom.ToUpper().Contains(nomIngredient))
                    .ToList();
            }

            return ingredients;
        }
    }

}
