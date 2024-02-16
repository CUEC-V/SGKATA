using Microsoft.EntityFrameworkCore;
using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.DEPOT
{
    public class RecetteDepot : Repository<Recette>, IRecetteDepot
    {
        public RecetteDepot(SGDbContext context) : base(context) { }

        public List<Recette> GetAll(string nomRecette = "")
        {
            var recettes = Context.Set<Recette>()
                .Include(a => a.Ingredients)
                .ToList();

            if (!string.IsNullOrEmpty(nomRecette))
            {
                nomRecette = nomRecette.ToUpper();

                recettes = recettes
                    .Where(r => r.Nom.ToUpper().Contains(nomRecette))
                    .ToList();
            }

            return recettes;
        }
    }
}
