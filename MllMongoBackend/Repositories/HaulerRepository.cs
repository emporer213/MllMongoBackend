using MllMongoBackend;
using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;
public interface IHaulerRepository
{
}

public class HaulerRepository : Repository<Hauler>, IHaulerRepository
{
    public HaulerRepository(IDbContext dbContext) : 
        base(dbContext)
    {
        
    }
}


