using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SG.ENTITE
{
    public class Recipe : EntityBase
    {
        [Required(ErrorMessage ="{0} is required")]
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
