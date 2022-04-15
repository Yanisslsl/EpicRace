namespace App.Models
{
    public class Pilot
    {
        private int Id { get; set; }

        private string FirstName { get; set; }
        
        private string LastName { get; set; }

        private DateOnly BirthDay { get; set; }

        private String Email {get; set; }

        private List<Vehicule> Vehicules { get; set; }

        private List<Race> RaceList {get; set; }
    }
}