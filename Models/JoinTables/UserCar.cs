
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class UserCar
    {
    public int UserCarId { get; set; }

    public int CarId { get; set; }
    public Car Car { get; set; }
    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    }
}