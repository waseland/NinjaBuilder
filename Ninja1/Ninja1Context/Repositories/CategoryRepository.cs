using Ninja1Context.Context;
using Ninja1Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Repositories
{
    public class CategoryRepository
    {
        private NinjaContext DbContext;

        public CategoryRepository(NinjaContext ninjaContext) {
            this.DbContext = ninjaContext;
        }

        public EquipmentCategory GetCategory(int id) {
            return DbContext.Category.Find(id);
        }

        public IEnumerable<EquipmentCategory> GetAllCategory() {
            return DbContext.Category.ToList();
        }

        public void CreateCategory(EquipmentCategory Category) {
            DbContext.Category.Add(Category);
        }

        public void UpdateCategory(EquipmentCategory Category)
        {
            DbContext.Entry(Category).State = System.Data.Entity.EntityState.Modified;
            this.Save();
        }

        public void Delete(int Id)
        {
            EquipmentCategory category = DbContext.Category.Find(Id);
            DbContext.Category.Remove(category);
            this.Save();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }


    }
}
