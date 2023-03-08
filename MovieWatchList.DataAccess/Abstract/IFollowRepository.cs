using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.Abstract
{
    public interface IFollowRepository
    {
        void FollowUser(string userId, string getFollowId);
        void UnfollowUser(string userId, string getFollowId);
        List<string> GetFollowByUserId(string userId);



    }
}
