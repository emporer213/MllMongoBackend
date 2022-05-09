using MllMongoBackend.Repositories.Interfaces;
using Route = MllMongoBackend.Models.Route;

namespace MllMongoBackend.Repositories;

public class RouteRepository : IRepository<Route>
{
    public async Task<ICollection<Route>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Route> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(Route item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(Route item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
