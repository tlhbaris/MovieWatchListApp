using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Entities
{
    public class Follow
    {
        //public int Id { get; set; }
        public string GetFollowId { get; set; }

        //navigation
        public string UserId { get; set; }
        public User User { get; set; }
        //public List<FollowUser> FollowUsers { get; set; }


    }
}
