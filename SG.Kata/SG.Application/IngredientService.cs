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
        private readonly IIngredientRepository _ingredientDepot;
        private readonly ILogger<IngredientService> _logger;

        public IngredientService(IIngredientRepository ingredientDepot, ILogger<IngredientService> logger)
        {
            _ingredientDepot = ingredientDepot;
            _logger = logger;
        }

        public void Add(Ingredient entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Cannot add null Ingredient");
            }

            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new ArgumentNullException("Name is required for Ingredient");
            }

            if (string.IsNullOrEmpty(entity.RecipeId))
            {
                throw new ArgumentNullException("Recipe is required for this ingredient");
            }

            if (Convert.ToDecimal(entity.Price) < 0)
            {
                throw new ArgumentOutOfRangeException("Price must be a 0 or positive value");
            }

            if (entity.Dose < 1)
            {
                throw new ArgumentOutOfRangeException("Dose must be a positive integer");
            }

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
