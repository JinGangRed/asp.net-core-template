using Contracts.Repository;
namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
    }
}
