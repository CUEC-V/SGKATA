using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SG.ENTITE
{
    public class Ingredient : EntityBase
    {
        public string Nom { get; set; }

        public string Prix { get; set; }

        public int Dose { get; set; }

        [ForeignKey("recetteid")]
        public string RecetteId { get; set; }

        public Recette Recette { get; set; }
    }
}
