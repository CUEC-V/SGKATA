using SG.ENTITE;
using System.Collections.Generic;

namespace SG.DEPOT
{
    public interface IRecetteDepot : IRepository<Recette>
    {
        List<Recette> GetAll(string nomRecette = "");
    }
}