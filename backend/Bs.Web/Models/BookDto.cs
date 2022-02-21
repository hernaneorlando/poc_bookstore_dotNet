using System.Collections.Generic;

namespace Bs.Web.Models
{
    public class BookDto
    {
        public string Name { get; private set; }
        public PublishCompanyDto PublishCompany { get; private set; }
        public IReadOnlyList<AuthorDto> Authors { get; private set; }

        public BookDto(string name, PublishCompanyDto publishCompany, IReadOnlyList<AuthorDto> authors)
        {
            Name = name;
            PublishCompany = publishCompany;
            Authors = authors;
        }
    }
}