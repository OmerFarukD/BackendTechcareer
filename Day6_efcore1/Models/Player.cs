using System.ComponentModel.DataAnnotations.Schema;

namespace Day6_efcore1.Models;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string BranchName { get; set; }
    public string TeamName { get; set; }
    public decimal Price { get; set; }
}
