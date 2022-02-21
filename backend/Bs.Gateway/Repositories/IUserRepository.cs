using Bs.Gateway.Entities;

namespace Bs.Gateway.Repositories
{
    public interface IUserRepository
    {
        Task<IList<UserEntity>> FindAll();
    }
}