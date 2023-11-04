namespace Day4_BookProject.Data;

public interface IEntityBaseRepository<TEntity,TId>
{
    void Add(TEntity category);
    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);

}
