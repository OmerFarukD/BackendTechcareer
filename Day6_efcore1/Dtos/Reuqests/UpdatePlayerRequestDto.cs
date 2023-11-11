namespace Day6_efcore1.Dtos.Reuqests;

public class UpdatePlayerRequestDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string BranchName { get; set; }
    public string TeamName { get; set; }
    public decimal Price { get; set; }
}
