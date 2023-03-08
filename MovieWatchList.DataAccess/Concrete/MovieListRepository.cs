using Microsoft.EntityFrameworkCore;
using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.DataAccess.DTOs;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.Concrete
{
    public class MovieListRepository : IMovieListRepository
    {
        public void CreateMovieList(MovieList movieList)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                movieDbContext.MoviesLists.Add(movieList);
                movieDbContext.SaveChanges();


            }
            
        }

        public void DeleteMovieList(int id)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                var deletedList = movieDbContext.MoviesLists.Find(id);

                if (deletedList != null)
                {
                    movieDbContext.MoviesLists.Remove(deletedList);
                    movieDbContext.SaveChanges();
                }
                else
                {
                    
                }

            }
        }

        public MovieList GetMovieList(int id)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                return movieDbContext.MoviesLists.Where(x => x.MovieListId == id)
                                                  .Include(x=>x.User)
                                                  .Include(x => x.MovieListMovies)
                                                  .ThenInclude(x => x.Movie)
                                                  .FirstOrDefault();






            }
        }

        public List<MovieList> GetMovieListByUserId(string userId)
        {
            using (var movieDbContext = new MovieDbContext())
            {
               return movieDbContext.MoviesLists.Where(x => x.UserId == userId).ToList();
            }
        }

        public void MovieListAddMovie(int movieListId, int externalApiId)
        {

            using (var movieDbContext = new MovieDbContext())
            {
                try
                {
                    MovieListMovie movie = new MovieListMovie();
                    movie.MovieListId = movieListId;
                    movie.ExternalApiId = externalApiId;
                    //movie.Movie.Id = 1;


                    movieDbContext.MoviesListMovies.Add(movie);
                    movieDbContext.SaveChanges();
                }
                catch (Exception ex )
                {

                    
                }
               

            }


        }

        public void MovieListDeleteMovie(int movieListId, int extarnalApiId)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                var deletedMovie = movieDbContext.MoviesListMovies
                                    .Where(x => x.MovieListId == movieListId && x.ExternalApiId == extarnalApiId).FirstOrDefault();
                movieDbContext.MoviesListMovies.Remove(deletedMovie);
                movieDbContext.SaveChanges();
            }
        }

        public void UpdateMovieList(MovieListUpdateDto movieList)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                //var result =  movieDbContext.MoviesLists.Find(movieList.MovieListId);

                try
                {
                    var result = movieDbContext.MoviesLists.Where(x => x.MovieListId == movieList.MovieListId)
                                           .Include(x => x.MovieListMovies)
                                           .ThenInclude(x => x.Movie)
                                           .First();
                    result.Description = movieList.Description;
                    result.ListName = movieList.ListName;
                    movieDbContext.SaveChanges();

                }
                catch (Exception ex)
                {
                    
                }


            };
            
        }
    }
}
