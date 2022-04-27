using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateCategoryRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre véhicule")]
        [MaxLength(10)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }
        
        [Required]
        public string? ImageUrl { get; init; }
       
        [Required]
        public string? Color { get; init; }

    }
}