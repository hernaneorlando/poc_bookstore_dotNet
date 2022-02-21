using Bs.Domain.Extensions;
using Bs.Domain.Models;
using Bs.Gateway.Repositories;

namespace Bs.Domain.Services.Implementation
{
    internal class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<IReadOnlyList<Book>> FindAll()
        {
            var entities = await bookRepository.FindAll();
            return entities.Select(e => e.ToModel()).ToArray();
        }

        public async Task<Book> FindById(long id)
        {
            var entity = await bookRepository.FindById(id);
            return entity.ToModel();
        }
    }
}