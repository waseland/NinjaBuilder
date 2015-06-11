using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Models
{
    public class Equipment
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int agility { get; set; }
        public virtual EquipmentCategory categorie { get; set; }
        public virtual ICollection<Ninja_User> user { get; set; }

        public Equipment(string name, int strength, int intelligence, int agility, EquipmentCategory equipmentCategory)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.agility = agility;
            this.categorie = categorie;
        }

        public Equipment() {
        }

    }
}
