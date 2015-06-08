using Ninja1Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Repositories
{
    public interface IUserRepository
    {
        List<Ninja_User> ToList();
    }
}
