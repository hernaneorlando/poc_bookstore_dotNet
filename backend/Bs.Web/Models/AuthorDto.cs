namespace Bs.Web.Models
{
    public class AuthorDto
    {
        public string Name { get; private set; }

        public AuthorDto(string name)
        {
            Name = name;
        }
    }
}