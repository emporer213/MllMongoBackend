using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;
using MongoDB.Driver;

namespace MllMongoBackend.Repositories;

public interface ISystemRepository
{
}

public class SystemRepository : Repository<SolarSystem>, ISystemRepository
{
    public SystemRepository(IDbContext dbContext) : 
        base(dbContext)
    {
    }
}


