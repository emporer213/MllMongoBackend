using MllMongoBackend.Repositories.Interfaces;
using Route = MllMongoBackend.Models.Route;

namespace MllMongoBackend.Repositories;

public interface IRouteRepository
{
}

public class RouteRepository : Repository<Route>, IRouteRepository
{
    public RouteRepository(IDbContext dbContext) :
        base(dbContext)
    {
    }
}


