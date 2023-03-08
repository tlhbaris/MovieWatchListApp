using Microsoft.EntityFrameworkCore.ChangeTracking;
using MovieWatchList.Business.Abstract;
using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Business.Concrete
{
    public class FollowManager : IFollowService
    {
        private readonly IFollowRepository _followRepository;
        public FollowManager(IFollowRepository followRepository)
        {
            _followRepository = followRepository;
        }

        public void FollowUser(string userId, string getFollowId)
        {
            _followRepository.FollowUser(userId, getFollowId);
        }

        public List<string> GetFollowByUserId(string userId)
        {
           return _followRepository.GetFollowByUserId(userId);
        }

        public void UnfollowUser(string userId, string getFollowId)
        {
            _followRepository.UnfollowUser(userId, getFollowId);

        }
    }
}
