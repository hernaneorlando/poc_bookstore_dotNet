using Bs.Domain.Models;
using Bs.Gateway.Entities;

namespace Bs.Domain.Extensions
{
    internal static class ConverterExtensions
    {
        public static Book ToModel(this BookEntity book)
        {
            return new Book
            {
                Name = book.Title,
                PublishCompany = book.Publisher.ToModel(),
                Authors = book.Authors.Select(a => a.ToModel()).ToArray()
            };
        }

        public static Author ToModel(this AuthorEntity author)
        {
            return new Author { Name = author.Name };
        }

        public static PublishCompany ToModel(this PublisherEntity publishCompany)
        {
            return new PublishCompany { Name = publishCompany.Name };
        }

        public static User ToModel(this UserEntity userEntity)
        {
            return new User { UserName = userEntity.UserName };
        }
    }
}