using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Entities;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<User> Get([FromQuery] string email, [FromQuery] string password)
        {
            return _userService.GetUser(email, password);
        }

        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            return _userService.AddUser(user);
        }



    }
}
