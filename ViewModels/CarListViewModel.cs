using App.Models;

namespace App.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> CarList { get; }
        public string HeaderTitle { get; }
        public CarListViewModel(IEnumerable<Car> cars, string headerTitle)
        {
            CarList = cars;
            HeaderTitle = headerTitle;
        }
    }
}