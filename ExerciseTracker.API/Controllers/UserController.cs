using ExerciseTracker.Modules.Modules;
using ExerciseTracker.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/api/exercise/users")]
        public async Task<List<UserViewModel>> Get()
        {
            return await _userService.GetAllUser();
        }

        [HttpPost("/api/exercise/new-user")]
        public async Task Post([FromBody] UserViewModel user)
        {
            await _userService.CreateUser(user);
        }
    }
}
