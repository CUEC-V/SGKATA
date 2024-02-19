using System;
using System.Collections.Generic;
using System.Text;

namespace SG.UNIT.TESTS.Models
{
    public class RecipeDto
    {
        public string Id { get; set; }  

        public string Name { get; set; }

        public List<IngredientDto> Ingredients { get; set;}
    }
}
