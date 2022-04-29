using App.Models;

namespace App.ViewModels
{
    public class EditUserViewModel
    {

        public ApplicationUser Driver { get; set; }

        public IEnumerable<Car> Cars { get; set; }


        public EditUserViewModel(ApplicationUser driver, IEnumerable<Car> cars)
        {
            Driver = driver;
            Cars = cars;
        }
    }
}