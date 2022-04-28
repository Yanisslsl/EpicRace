using System.ComponentModel.DataAnnotations;
using App.Models;

namespace App.ViewModels
{
    public class CreateCarRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre véhicule")]
        [MaxLength(10)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        
        [Required]
        public string? Brand { get; init; }
       
        [Required]
        public string? Model { get; init; }

        [Required]
        public int CategoryId { get; init; }

        public Category Category { get; init; }




    }
}