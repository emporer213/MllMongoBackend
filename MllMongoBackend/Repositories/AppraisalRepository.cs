using MllMongoBackend.Models;
using MllMongoBackend.Repositories.Interfaces;

namespace MllMongoBackend.Repositories;

public interface IAppraisalRepository
{
}

public class AppraisalRepository : Repository<Appraisal> , IAppraisalRepository
{
    public AppraisalRepository(IDbContext dbContext) : 
        base(dbContext)
    {
        
    }
   
}
