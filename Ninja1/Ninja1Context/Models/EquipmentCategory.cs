using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Models
{
    public class EquipmentCategory
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public EquipmentCategory() {
        }

        public EquipmentCategory(string name)
        {
            this.name = name;
        }

    }
}
