using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.Abstract
{
    public interface IUserRepository
    {

        User GetUserById(string id);

    }
}
