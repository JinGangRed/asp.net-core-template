using Contracts.Repository;
using Domain;
using Domain.DBModels;

namespace Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RepositoryContext RepositoryContext) : base(RepositoryContext)
        {
        }
    }
}
