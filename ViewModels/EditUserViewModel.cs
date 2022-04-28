using App.Models;

namespace App.ViewModels
{
    public class EditUserViewModel
    {

        public ApplicationUser Driver { get; set; }

        public EditUserViewModel(ApplicationUser driver)
        {
            Driver = driver;
        }
    }
}