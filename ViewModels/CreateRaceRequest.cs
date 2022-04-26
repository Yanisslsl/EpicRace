using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre course")]
        [MaxLength(10)]
        public string? RaceName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }

        public string? Latitude { get; set; }
        
        [Required]
        public string? Longitude { get; set; }

        public DateTime StartTime { get; set; }
        public string? ImageUrl { get; set; }

        public string? Result { get; set; }




    }
}