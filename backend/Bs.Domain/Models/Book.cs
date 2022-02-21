namespace Bs.Domain.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public PublishCompany PublishCompany { get; set; }
        public IReadOnlyList<Author> Authors { get; set; }
    }
}
