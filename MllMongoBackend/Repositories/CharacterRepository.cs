using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public interface ICharacterRepository
{
}

public class CharacterRepository : Repository<Character>, ICharacterRepository
{
    public CharacterRepository(IDbContext dbContext) : 
        base(dbContext)
    {
    }
   
}
