
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; } // add required f
        public string? Name { get; init; }
        public DateTime CreationDate { get; init; }
        public string? Brand { get; init; }
        public string? Model { get; init; }
        public int LevelPower { get; set; }
        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<UserCar> UserCars { get; set; }





    }
}