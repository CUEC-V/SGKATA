using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SG.ENTITE
{
    public class Ingredient : EntityBase
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Price { get; set; }

        [Range(1, int.MaxValue)]
        public int Dose { get; set; }

        [ForeignKey("recipeid")]
        [Required(ErrorMessage ="{0} is required")]
        public string RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
