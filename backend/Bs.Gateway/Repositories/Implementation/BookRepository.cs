using Bs.Gateway.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bs.Gateway.Repositories.Implementation
{
    internal class BookRepository : IBookRepository
    {
        private readonly SqlDataContext dataContext;

        public BookRepository(SqlDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IList<BookEntity>> FindAll()
        {
            return await dataContext.Set<BookEntity>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<BookEntity> FindById(long id)
        {
            return await dataContext.Set<BookEntity>()
                .Where(b => b.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
