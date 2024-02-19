using SG.ENTITE;
using System.Collections.Generic;

namespace SG.DEPOT
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        List<Ingredient> GetAll(string nomIngredient = "");
    }
}