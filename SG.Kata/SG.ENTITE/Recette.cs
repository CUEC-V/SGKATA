using System;
using System.Collections.Generic;
using System.Text;

namespace SG.ENTITE
{
    public class Recette : EntityBase
    {
        public string Nom { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
