using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Business.Abstract
{
    public interface IUserService
    {
        User GetUserById(string id);


    }
}
