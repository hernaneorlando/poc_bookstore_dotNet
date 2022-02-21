using System.Linq;
using Bs.Domain.Models;

namespace Bs.Web.Models.Extensions
{
    internal static class ConverterExtensions
    {
        public static BookDto ToDto(this Book book)
        {
            return new BookDto
            (
                book.Name,
                book.PublishCompany.ToDto(),
                book.Authors.Select(a => a.ToDto()).ToArray()
            );
        }

        public static AuthorDto ToDto(this Author author)
        {
            return new AuthorDto(author.Name);
        }

        public static PublishCompanyDto ToDto(this PublishCompany publishCompany)
        {
            return new PublishCompanyDto(publishCompany.Name);
        }

        public static UserDto ToDto(this User user)
        {
            return new UserDto(user.UserName);
        }
    }
}