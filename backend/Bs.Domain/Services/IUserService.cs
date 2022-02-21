using Bs.Domain.Models;

namespace Bs.Domain.Services
{
    public interface IUserService
    {
        Task<IReadOnlyList<User>> FindAll();
    }
}