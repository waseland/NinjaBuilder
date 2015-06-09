using Ninja1Context.Context;
using Ninja1Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Repositories
{
    public class UserRepository
    {
         private NinjaContext DbContext;

        public UserRepository(NinjaContext ninjaContext) {
            this.DbContext = ninjaContext;
        }

        public Ninja_User GetUser(int id)
        {
            return DbContext.User.Find(id);
        }

        public IEnumerable<Ninja_User> GetAllUser()
        {
            return DbContext.User.ToList();
        }

        public void CreateUser(Ninja_User user)
        {
            DbContext.User.Add(user);
        }

        public void UpdateUser(Ninja_User user)
        {
            DbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
            this.Save();
        }

        public void Delete(int Id)
        {
            Ninja_User user = DbContext.User.Find(Id);
            DbContext.User.Remove(user);
            this.Save();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
