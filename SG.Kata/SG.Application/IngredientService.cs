using Microsoft.Extensions.Logging;
using SG.DEPOT;
using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.Application
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientDepot _ingredientDepot;
      //  private readonly ILogger<IngredientService> _logger;

        public IngredientService(IIngredientDepot ingredientDepot/*, ILogger<IngredientService> logger*/)
        {
            _ingredientDepot = ingredientDepot;
          //  _logger = logger;
        }

        public void Add(Ingredient entity)
        {
            _ingredientDepot.Add(entity);
        }

        public int Delete(Ingredient entity)
        {
            return _ingredientDepot.Delete(entity);
        }

        public Ingredient FindById(string id)
        {
            return _ingredientDepot.FindById(id);
        }

        public List<Ingredient> GetAll(string nomIngredient = "")
        {
            return _ingredientDepot.GetAll(nomIngredient);
        }

        public int Update(Ingredient entity)
        {
            return _ingredientDepot.Update(entity);
        }
    }
}
