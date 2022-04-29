
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class CarCategory
    {
    public int Id { get; set; }

    public int CarId { get; set; }
    public Car Car { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    }
}