using Bs.Gateway.Entities;

namespace Bs.Gateway.Repositories
{
    public interface IBookRepository
    {
        Task<IList<BookEntity>> FindAll();
        Task<BookEntity> FindById(long id);
    }
}