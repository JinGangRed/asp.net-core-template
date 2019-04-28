using Contracts;
using Contracts.Repository;
using System;


namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IUserRepository User;
        public RepositoryWrapper()
        {

        }

        public IUserRepository UserRepository
        {
            get
            {
                if (User == null)
                {
                    throw new Exception($"{nameof(UserRepository)} is not config on the DI service");
                }
                return UserRepository;
            }

        }
    }
}
