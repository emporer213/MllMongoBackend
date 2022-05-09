using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public class SystemRepository : IRepository<SolarSystem>
{
    public async Task<ICollection<SolarSystem>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<SolarSystem> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(SolarSystem item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(SolarSystem item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
