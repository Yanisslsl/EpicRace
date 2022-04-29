using App.Models;

namespace App.ViewModels
{
    public class EditRaceViewModel
    {

        public Race Race { get; set; }

        public IEnumerable<ApplicationUser> Drivers { get; set; }


        public EditRaceViewModel(Race race, IEnumerable<ApplicationUser> drivers)
        {
            Race = race;
            Drivers = drivers;
        }
    }
}