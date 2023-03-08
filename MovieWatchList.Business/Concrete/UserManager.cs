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
    public class UserManager :IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
              _userRepository= userRepository;
        }

        public User GetUserById(string id)
        {
            return _userRepository.GetUserById(id); 
        }

    }
}
