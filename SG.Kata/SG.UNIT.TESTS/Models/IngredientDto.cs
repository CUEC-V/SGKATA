using SG.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SG.UNIT.TESTS.Models
{
    public class IngredientDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Dose { get; set; }

        public string RecipeId { get; set; }
    }
}
