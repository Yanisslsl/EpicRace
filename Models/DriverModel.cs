
using Microsoft.AspNetCore.Identity;
namespace App.Models;


public class ApplicationUser : IdentityUser

{
    // public int UserId { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public ICollection<UserCar> UserCars { get; set; }

}