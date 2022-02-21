namespace Bs.Web.Models
{
    public class UserDto
    {
        public string UserName { get; private set; }

        public UserDto(string userName)
        {
            UserName = userName;
        }
    }
}