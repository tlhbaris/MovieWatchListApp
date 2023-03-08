using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MovieWatchList.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User GetUserById(string id)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                return movieDbContext.Users.Find(id);
            }
        }

        
    }




}
