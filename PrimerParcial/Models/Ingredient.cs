using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using PrimerParcial.Models;

namespace PrimerParcial.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Quantity { get; set; }

        public int RecipeId { get; set; }

        // Propiedad de Navegación: El lado 'uno'
        public Recipe Recipe { get; set; }
    }
}