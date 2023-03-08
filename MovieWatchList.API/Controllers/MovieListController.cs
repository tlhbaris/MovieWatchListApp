using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieWatchList.Business.Abstract;
using MovieWatchList.DataAccess.DTOs;
using MovieWatchList.Entities;

namespace MovieWatchList.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieListController : ControllerBase
    {
        private readonly IMovieListService _movieListService;
        public MovieListController(IMovieListService movieListService)
        {
           _movieListService = movieListService;
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateMovieList(MovieListDto movieListDto)
        {
            var movieList = new MovieList { 
                ListName= movieListDto.ListName,
                Description= movieListDto.Description,
                UserId= movieListDto.UserId

            };

          _movieListService.CreateMovieList(movieList);
            return Ok();
        }
        [HttpGet]
        [Route("[action]/{id}")]

        public IActionResult GetMovieListByMovieListId(int id)
        {
            var getMovieListById = _movieListService.GetMovieList(id);


            var GetList = new GetMovieListDto
            {
                MovieListId = getMovieListById.MovieListId,
                ListName = getMovieListById.ListName,
                Description = getMovieListById.Description,
                CreatedTime = getMovieListById.CreatedTime,
                UserId = getMovieListById.UserId,
                UserName = getMovieListById.User.UserName,
                Movies = getMovieListById.MovieListMovies.Select(x=>x.ExternalApiId).ToList()
            };


            return Ok(GetList);
        }
        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult DeleteMovieList(int id)
        {
            _movieListService.DeleteMovieList(id);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult UpdateMovieList(MovieListUpdateDto movieList)
        {
           
            _movieListService.UpdateMovieList(movieList);
            return Ok();

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult MovieListAddMovie(MovieListAddMovieParam movieList)
        {

            _movieListService.MovieListAddMovie(movieList.MovieListId,movieList.ExternalApiId);
            return Ok();
        }



        [HttpPost]
        [Route("[action]")]
        public IActionResult MovieListDeleteMovie(MovieListAddMovieParam movieList)    
        {

            _movieListService.MovieListDeleteMovie(movieList.MovieListId, movieList.ExternalApiId);
            return Ok();

        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult GetMovieListByUserId(string userId)
        {
           var movieList = _movieListService.GetMovieListByUserId(userId);
            return Ok(movieList);
        }


    }
}
