using Microsoft.Extensions.Logging;
using SG.DEPOT;
using SG.ENTITE;
using System;
using System.Collections.Generic;

namespace SG.Application
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteDepot _recetteDepot;
       // private readonly ILogger<RecetteService> _logger;

        public RecetteService(IRecetteDepot recetteDepot/*, ILogger<RecetteService> logger*/)
        { 
            _recetteDepot = recetteDepot;
           // _logger = logger;
        }

        public void Add(Recette entity)
        {
            _recetteDepot.Add(entity);
        }

        public int Delete(Recette entity)
        {
           return _recetteDepot.Delete(entity);
        }

        public Recette FindById(string id)
        {
            return _recetteDepot.FindById(id);
        }

        public List<Recette> GetAll(string nomRecette = "")
        {
            return _recetteDepot.GetAll(nomRecette);
        }

        public int Update(Recette entity)
        {
            return _recetteDepot.Update(entity);
        }
    }
}
