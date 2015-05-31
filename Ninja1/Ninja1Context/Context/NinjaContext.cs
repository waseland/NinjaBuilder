using Ninja1Context.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Context
{
    public class NinjaContext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipmentCategory> Category { get; set; }
        public DbSet<Ninja_User> User { get; set; }
    }
}
