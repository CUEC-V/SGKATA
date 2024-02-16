using SG.ENTITE;
using System.Collections.Generic;

namespace SG.DEPOT
{
    public interface IIngredientDepot : IRepository<Ingredient>
    {
        List<Ingredient> GetAll(string nomIngredient = "");
    }
}