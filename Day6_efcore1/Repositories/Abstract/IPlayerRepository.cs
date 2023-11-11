using Day6_efcore1.Models;

namespace Day6_efcore1.Repositories.Abstract;

public interface IPlayerRepository
{
    void Add(Player player);
    Player? GetById(int id);
    void Delete(int id);
    void Update(Player player);
    List<Player> GetAll();
}
