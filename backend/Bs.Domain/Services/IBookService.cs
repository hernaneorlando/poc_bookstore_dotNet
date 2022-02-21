using Bs.Domain.Models;

namespace Bs.Domain.Services
{
    public interface IBookService
    {
        Task<IReadOnlyList<Book>> FindAll();
        Task<Book> FindById(long id);
    }
}