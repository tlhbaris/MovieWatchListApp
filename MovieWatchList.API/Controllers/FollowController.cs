using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MovieWatchList.Business.Abstract;

namespace MovieWatchList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowController : ControllerBase
    {
        private readonly IFollowService _followService;
        public FollowController(IFollowService followService)
        {
            _followService = followService;
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult FollowUser(string userId, string getFollowId)
        {
            _followService.FollowUser(userId, getFollowId);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult UnfollowUser(string userId, string getFollowId)
        {
            _followService.UnfollowUser(userId, getFollowId);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GetFollowByUserId(string userId)
        {
           var result = _followService.GetFollowByUserId(userId);
            if (result !=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    



    }
}
