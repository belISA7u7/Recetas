using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using PrimerParcial.Models;

namespace PrimerParcial.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required] 
        public string Description { get; set; }

        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}