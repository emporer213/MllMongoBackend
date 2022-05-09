using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public class ServiceRepository : IRepository<Service>
{
    public async Task<ICollection<Service>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Service> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(Service item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(Service item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
