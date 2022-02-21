using Bs.Domain.Extensions;
using Bs.Domain.Models;
using Bs.Gateway.Repositories;

namespace Bs.Domain.Services.Implementation
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IReadOnlyList<User>> FindAll()
        {
            var entities = await userRepository.FindAll();
            return entities.Select(e => e.ToModel()).ToArray();
        }
    }
}