using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieWatchList.Business.Abstract;
using MovieWatchList.Entities;

namespace MovieWatchList.API.Controllers
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

        [HttpPost]
        [Route("[action]/{id}")]
        public IActionResult GetUserById(string id) 
        {
           User user = _userService.GetUserById(id);
            return Ok(user);


        }

    }
}
