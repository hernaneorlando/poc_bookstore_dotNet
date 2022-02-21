using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Bs.Domain.Services;
using Bs.Web.Models;
using Bs.Web.Models.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bs.Web.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        public readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("users", Name = nameof(GetUsers))]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UserDto>> GetUsers()
        {
            var users = await userService.FindAll();
            return Ok(users.Select(user => user.ToDto()));
        }
    }
}