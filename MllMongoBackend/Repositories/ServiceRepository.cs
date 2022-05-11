using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public interface IServiceRepository
{
}

public class ServiceRepository : Repository<Service>, IServiceRepository
{
    public ServiceRepository(IDbContext dbContext) : 
        base(dbContext)
    {
    }
}


