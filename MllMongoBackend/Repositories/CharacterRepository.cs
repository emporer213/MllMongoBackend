using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public class CharacterRepository : IRepository<Character>
{
    public async Task<ICollection<Character>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Character> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(Character item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(Character item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
