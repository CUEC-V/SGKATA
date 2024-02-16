using System;
using System.Collections.Generic;
using System.Text;

namespace SG.Kata.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public decimal Prix { get; set; }

        public int Dose { get; set; }
    }
}
