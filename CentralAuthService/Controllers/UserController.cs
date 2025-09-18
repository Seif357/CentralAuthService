using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        [Route("api/[controller] Register")]
        [HttpPost]
        public string Register(UserDTO userDTO)
        {
            return userService.AddUser(userDTO);
        }
        [Route("api/[controller] UpdateInfo")]

        [HttpPut]
        public string UpdateInfo(UserDTO userDTO)
        {
            return userService.UpdateUser(userDTO);
        }
        [Route("api/[controller] Login")]

        [HttpGet]
        public User Login(int id)
        {
            return userService.GetUser(id);
        }
    }
}
