using Day6_efcore1.Models;

namespace Day6_efcore1.Dtos.Responses;

public class OutfitDto
{
    public int Id { get; set; }
    public OutfitType Type { get; set; }
    public short No { get; set; }
    public string BrandName { get; set; }
}
