
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; } // add required f
        public string? Name { get; init; }
        public DateTime EventDate { get; init; }
        public string? Latitude { get; init; }
        public string? Longitude { get; init; }
        public DateTime StartTime { get; set; }
        public string? ImageUrl { get; set; }
        public int MaxParticipants { get; set; } = 15;

        public int MinAge { get; set; } = 21;

        public string? Result { get; set; }

    }
}