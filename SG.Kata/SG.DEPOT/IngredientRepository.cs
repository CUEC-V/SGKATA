using Microsoft.EntityFrameworkCore;
using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.DEPOT
{
    public class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(SGDbContext context) : base(context) { }

        public List<Ingredient> GetAll(string nomIngredient = "")
        {
            var ingredients = Context.Set<Ingredient>()
                .Include(a => a.Recipe)
                .ToList();

            if (!string.IsNullOrEmpty(nomIngredient))
            {
                nomIngredient = nomIngredient.ToUpper();

                ingredients = ingredients
                    .Where(r => r.Name.ToUpper().Contains(nomIngredient))
                    .ToList();
            }

            return ingredients;
        }
    }

}
