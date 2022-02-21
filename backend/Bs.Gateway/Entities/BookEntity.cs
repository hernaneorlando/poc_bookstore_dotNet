namespace Bs.Gateway.Entities
{
    public class BookEntity
    {
        public long Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }   
        public int Pages { get; set; }
        public virtual PublisherEntity Publisher { get; set; }
        public virtual IReadOnlyList<AuthorEntity> Authors { get; set; }
    }
}