namespace App.Models
{
    public class Vehicule
    {
        private int Id {get; set; }

        private VehiculeCategory Category {get; set; }

        private DateOnly BuldingYear {get; set; }

        private string Brand {get; set; } // enum ou class ?

        private int Power {get; set; }

        private List<Pilot> PilotList {get; set; }

        private string ImageLink {get; set; }
    }
}