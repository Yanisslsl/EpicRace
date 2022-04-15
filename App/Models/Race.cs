
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        private int Id { get; set; }

        private string? Name { get; set; }

        private DateTime EventDate { get; set; }

        private DateTime StartingTime {get; set; }

        private float longitude {get; set; }

        private float latitude {get; set; }

        private int PilotsMax {get; set; }

        private string ImageLink {get; set; }

        private List<Pilot> PilotsList {get; set; }

        private int RequiredAge {get; set; }

        private List<RaceResult> Results {get; set; }
        private List<Vehicule> AllowedVehicule {get; set; }
    }
}