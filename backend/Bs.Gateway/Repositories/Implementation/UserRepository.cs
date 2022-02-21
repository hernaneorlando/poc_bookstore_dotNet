using Bs.Gateway.Entities;
using MongoDB.Driver;

namespace Bs.Gateway.Repositories.Implementation
{
    internal class UserRepository : IUserRepository
    {
        private readonly NoSqlDataContext dataContext;

        public UserRepository(NoSqlDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IList<UserEntity>> FindAll()
        {
            return await dataContext.Users
                .Find(FilterDefinition<UserEntity>.Empty)
                .ToListAsync();
        }
    }
}