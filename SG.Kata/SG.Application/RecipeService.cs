using Microsoft.Extensions.Logging;
using SG.REPOSITORY;
using SG.ENTITY;
using System;
using System.Collections.Generic;

namespace SG.Application
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recetteDepot;
       // private readonly ILogger<RecetteService> _logger;

        public RecipeService(IRecipeRepository recetteDepot/*, ILogger<RecetteService> logger*/)
        { 
            _recetteDepot = recetteDepot;
           // _logger = logger;
        }

        public void Add(Recipe entity)
        {
            if( entity == null )
            {
                throw new ArgumentNullException("Cannot add null Recipe");
            }

            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new ArgumentNullException("Name is required for Recipe");
            }

            _recetteDepot.Add(entity);
        }

        public int Delete(Recipe entity)
        {
           return _recetteDepot.Delete(entity);
        }

        public Recipe FindById(string id)
        {
            return _recetteDepot.FindById(id);
        }

        public List<Recipe> GetAll(string nomRecette = "")
        {
            return _recetteDepot.GetAll(nomRecette);
        }

        public int Update(Recipe entity)
        {
            return _recetteDepot.Update(entity);
        }
    }
}
