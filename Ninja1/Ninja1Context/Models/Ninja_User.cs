﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context.Models
{
    public class Ninja_User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int gold { get; set; }
        public virtual ICollection<Equipment> currentEquipment { get; set; }
        public virtual ICollection<Equipment> boughtEquipment { get; set; }

        public Ninja_User(string name, int gold)
        {
            this.name = name;
            this.gold = gold;
        }
        public Ninja_User() {
        }
    }
}
