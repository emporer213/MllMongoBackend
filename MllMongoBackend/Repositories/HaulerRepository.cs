using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public class HaulerRepository : IRepository<Hauler>
{
    public async Task<ICollection<Hauler>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Hauler> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(Hauler item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(Hauler item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
