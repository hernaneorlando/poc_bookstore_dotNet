using AutoFixture;
using Bs.Domain.Models;
using Bs.Domain.Services;
using Bs.Domain.Services.Implementation;
using Bs.Gateway.Repositories;
using FluentAssertions;
using Moq;
using Xunit;

namespace Bs.DomainTests
{
    public class BookServiceTests
    {
        private readonly Mock<IBookRepository> repositoryMock;

        private readonly Fixture fixture;
        private readonly IBookService service;

        public BookServiceTests()
        {
            repositoryMock = new Mock<IBookRepository>();

            fixture = new Fixture();
            service = new BookService(repositoryMock.Object);
        }

        [Fact]
        public void FindBook_ById_ShouldReturnWithSuccess()
        {
            var expectedBook = fixture.Create<Book>();

            var result = service.FindById(expectedBook.Id);

            result.Should().BeEquivalentTo(expectedBook);
        }
    }
}
