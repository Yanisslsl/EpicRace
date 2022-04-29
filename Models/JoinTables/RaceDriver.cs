
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class RaceDriver
    {
    public int Id { get; set; }

    public int RaceId { get; set; }
    public Race Race { get; set; }
    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    }
}