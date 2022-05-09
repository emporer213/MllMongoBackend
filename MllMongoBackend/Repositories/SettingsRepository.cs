using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public class SettingsRepository : IRepository<Settings>
{
    public async Task<ICollection<Settings>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Settings> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(Settings item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(Settings item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
