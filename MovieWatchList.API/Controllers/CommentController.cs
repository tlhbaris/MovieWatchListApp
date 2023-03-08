using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieWatchList.Business.Abstract;

namespace MovieWatchList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService= commentService;
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult AddComment(string userId,int moveListId, string commentBody)
        {
           var result =_commentService.AddComment(userId, moveListId, commentBody);
            return Ok(result);
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult GetCommentsByMovieListId(int movieListId)
        {
          var movieList = _commentService.GetCommentsByMovieListId(movieListId);
            return Ok(movieList);
        }

    }
}
