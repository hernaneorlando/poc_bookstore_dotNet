namespace Bs.Web.Models
{
    public class PublishCompanyDto
    {
        public string Name { get; private set; }

        public PublishCompanyDto(string name)
        {
            Name = name;
        }
    }
}