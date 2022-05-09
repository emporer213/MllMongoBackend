namespace MllMongoBackend.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<ICollection<T>> GetAll();
    Task<T> Get(string id);
    Task<bool> Save(T item);
    Task<bool> Update(T item);
    Task<bool> Delete(string id);
}
