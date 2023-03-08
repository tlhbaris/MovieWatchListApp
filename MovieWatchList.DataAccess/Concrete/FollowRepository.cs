using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.Concrete
{
    public class FollowRepository : IFollowRepository
    {
        public void FollowUser(string userId, string getFollowId)
        {

            using (var movieDbContext = new MovieDbContext())
            {
                try
                {
                    Follow follow = new();
                    follow.UserId = userId;
                    follow.GetFollowId = getFollowId;
                    movieDbContext.Follows.Add(follow);
                    movieDbContext.SaveChanges();
                }
                catch (Exception ex)
                {


                }

            }

        }

        public List<string> GetFollowByUserId(string userId)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                try
                {
                   return movieDbContext.Follows.Where(x=>x.UserId == userId).Select(x=>x.GetFollowId).ToList();


                }
                catch (Exception ex)
                {

                    throw;
                }
            }     
        }

        public void UnfollowUser(string userId, string getFollowId)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                try
                {

                    var result = movieDbContext.Follows.Where(x => x.UserId == userId & x.GetFollowId == getFollowId).First();
                    movieDbContext.Follows.Remove(result);
                    movieDbContext.SaveChanges();


                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
