using MongoDB.Driver;

namespace MllMongoBackend.Repositories.Interfaces;

public abstract class Repository<T> where T : class
{
    private readonly IMongoCollection<T> _collection;

    protected Repository(IDbContext dbContext)
    {
        _collection = dbContext.GetCollection<T>();
    }
    public async Task<IEnumerable<T>> GetAll()
    {
        var result = await _collection.FindAsync(_ => true);

        return result.Current;
    }
    public async Task<T> Get(FilterDefinition<T> filter)
    {
        var result = await _collection.FindAsync(filter);

        return result.Current.Single();
    }
    public async Task<bool> Save(T item)
    {
        var task =  _collection.InsertOneAsync(item);
        
        await task;

        return task.IsCompletedSuccessfully;
    }
    public async Task<bool> Update(T item, FilterDefinition<T> filter)
    {
        var task = _collection.ReplaceOneAsync(filter, item);

        await task;

        return task.IsCompletedSuccessfully;
    }
    public async Task<bool> Delete(FilterDefinition<T> filter)
    {
        var task = _collection.DeleteOneAsync(filter);

        await task;

        return task.IsCompletedSuccessfully;
    }
}
