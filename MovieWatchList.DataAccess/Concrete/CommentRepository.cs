using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        public Comment AddComment(string userId, int moveList, string commentBody)
        {

			try
			{	using (var movieDbContext = new MovieDbContext())
				{

                    Comment comment = new Comment();
                    comment.UserId = userId;
                    comment.CommentBody = commentBody;
                    comment.MovieListId = moveList;
                    movieDbContext.Add(comment);
                    movieDbContext.SaveChanges();
                    return (comment);

                }
					



			}
			catch (Exception)
			{

				throw;
			}
        }

        public List<Comment> GetCommentsByMovieListId(int movieListId)
        {
            try
            {
                using (var movieDbContext = new MovieDbContext())
                {
                  var commentList =  movieDbContext.Comments.Where(x => x.MovieListId == movieListId).ToList();
                    return commentList;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
