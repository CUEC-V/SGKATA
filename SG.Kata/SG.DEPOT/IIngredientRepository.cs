using SG.ENTITY;
using System.Collections.Generic;

namespace SG.REPOSITORY
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        List<Ingredient> GetAll(string nomIngredient = "");
    }
}