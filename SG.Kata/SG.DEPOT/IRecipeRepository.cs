using SG.ENTITE;
using System.Collections.Generic;

namespace SG.DEPOT
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        List<Recipe> GetAll(string nomRecette = "");
    }
}