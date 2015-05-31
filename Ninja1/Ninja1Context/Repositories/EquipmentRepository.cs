using Ninja1Context.Context;
using Ninja1Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Repositories
{
    public class EquipmentRepository
    {
        private NinjaContext DbContext;

        public EquipmentRepository(NinjaContext ninjaContext)
        {
            this.DbContext = ninjaContext;
        }

        public Equipment GetEquipment(int id)
        {
            return DbContext.Equipment.Find(id);
        }

        public IEnumerable<Equipment> GetAllEquipment()
        {
            return DbContext.Equipment.ToList();
        }

        public void CreateEquipment(Equipment equipment)
        {
            DbContext.Equipment.Add(equipment);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            DbContext.Entry(equipment).State = System.Data.Entity.EntityState.Modified;
            this.Save();
        }

        public void Delete(int Id)
        {
            Equipment equipment = DbContext.Equipment.Find(Id);
            DbContext.Equipment.Remove(equipment);
            this.Save();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
