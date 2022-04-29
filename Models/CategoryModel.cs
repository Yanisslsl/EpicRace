
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Category
    {
        public int Id { get; set; } // add required f
        public string? Name { get; init; }
        public string? Description { get; init; }
        public string? ImageUrl { get; set; }
        public string? Color { get; set; }

        public List<CarCategory> CarCategories { get; set; }

    }
}