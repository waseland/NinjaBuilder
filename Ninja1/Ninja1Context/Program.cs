using Ninja1Context.Context;
using Ninja1Context.Models;
using Ninja1Context.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1Context
{
    class Program
    {
        static void Main(string[] args)
        {
            NinjaContext nc = new NinjaContext();

            CategoryRepository cr = new CategoryRepository(nc);
            
            EquipmentCategory e = new EquipmentCategory("Head");
            cr.CreateCategory(e);
            EquipmentCategory e1 = new EquipmentCategory("Shoulders");
            cr.CreateCategory(e1);
            EquipmentCategory e2 = new EquipmentCategory("Chest");
            cr.CreateCategory(e2);
            EquipmentCategory e3 = new EquipmentCategory("Belt");
            cr.CreateCategory(e3);
            EquipmentCategory e4 = new EquipmentCategory("Legs");
            cr.CreateCategory(e4);
            EquipmentCategory e5 = new EquipmentCategory("Boots");
            cr.CreateCategory(e5);

            EquipmentRepository er = new EquipmentRepository(nc);

            Equipment a = new Equipment("Head", 50, 50, 50, e);
            er.CreateEquipment(a);
            Equipment a1 = new Equipment("Shoulders", 50, 50, 50, e1);
            er.CreateEquipment(a1);
            Equipment a2 = new Equipment("Chest", 50, 50, 50, e2);
            er.CreateEquipment(a2);
            Equipment a3 = new Equipment("Belt", 50, 50, 50, e3);
            er.CreateEquipment(a3);
            Equipment a4 = new Equipment("Legs", 50, 50, 50, e4);
            er.CreateEquipment(a4);

            UserRepository ur = new UserRepository(nc);

            Ninja_User u = new Ninja_User("Jelmer", 100);
            ur.CreateUser(u);
            Ninja_User u1 = new Ninja_User("Guus", 1000);
            ur.CreateUser(u1);
            Ninja_User u2 = new Ninja_User("Bart", 10000);
            ur.CreateUser(u2);

        }
    }
}
