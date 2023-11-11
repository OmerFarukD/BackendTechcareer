using System.ComponentModel.DataAnnotations.Schema;

namespace Day6_efcore1.Models;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public int BranchId { get; set; }
    public Branch Branch { get; set; }

    public int TeamId { get; set; }
    public Team Team { get; set; }

    public int OutfitId { get; set; }
    public Outfit Outfit { get; set; }

    [Column(TypeName ="decimal(18,2)")]
    public decimal Price { get; set; }
}
