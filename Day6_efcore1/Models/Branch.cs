namespace Day6_efcore1.Models;

public class Branch
{
    public int Id { get; set; }
    public string BranchName { get; set; }

    public List<Player> Players { get; set; }

}
