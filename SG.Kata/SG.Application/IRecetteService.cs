using SG.ENTITE;
using System.Collections.Generic;

namespace SG.Application
{
    public interface IRecetteService
    {
        void Add(Recette entity);

        Recette FindById(string id);

        int Update(Recette entity);

        int Delete(Recette entity);

        List<Recette> GetAll(string nomRecette = "");
    }
}