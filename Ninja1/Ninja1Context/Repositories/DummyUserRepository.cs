using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninja1Context.Models;
using Ninja1Context.Context;
using System.Data.Entity;

namespace Ninja1Context.Repositories
{
    public class DummyUserRepository : IUserRepository
    {
        private NinjaContext DbContext;
        private UserRepository urepo;

        public DummyUserRepository(NinjaContext DbContext)
        {
            // TODO: Complete member initialization
            this.DbContext = DbContext;
        }

        public List<Ninja_User> ToList()
    {
        var users = new List<Ninja_User>();

        

        return users;
    }


    }
}
