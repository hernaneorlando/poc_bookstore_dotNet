namespace Bs.Domain.Models
{
    public class PublishCompany
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
    }
}