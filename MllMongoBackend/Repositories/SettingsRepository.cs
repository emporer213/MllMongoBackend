using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public interface ISettingsRepository
{
}

public class SettingsRepository : Repository<Settings>, ISettingsRepository
{
    public SettingsRepository(IDbContext dbContext) : 
        base(dbContext)
    {
    }
}

