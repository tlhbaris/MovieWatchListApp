using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Entities
{
    public class User : IdentityUser
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        //Navigation property
        public List<MovieList> MovieLists { get; set; }
        public ICollection<Comment> Comments { get; set; }
        //public List<Comment> Comments { get; set; }

        //public List<FollowUser> FollowUsers { get; set; }

    }
}
