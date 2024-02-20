using SG.ENTITY;
using System.Collections.Generic;

namespace SG.REPOSITORY
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        List<Recipe> GetAll(string nomRecette = "");
    }
}