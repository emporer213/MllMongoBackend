using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public class AppraisalRepository : IRepository<Appraisal>
{
    public async Task<ICollection<Appraisal>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Appraisal> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save(Appraisal item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Update(Appraisal item)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(string id)
    {
        throw new NotImplementedException();
    }
}
