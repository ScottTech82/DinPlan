using System.ComponentModel.DataAnnotations;

namespace DinnerPlanner.Models;

public class Meal
{
    public int Id { get; set; }
    [StringLength(30)]
    public string Name { get; set; }
    [StringLength(30)]
    public string Type { get; set; }
    [StringLength(255)]
    public string? Description { get; set; }


}
