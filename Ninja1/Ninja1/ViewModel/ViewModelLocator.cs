
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Ninja1Context.Context;
using Ninja1Context.Models;
using Ninja1Context.Repositories;
using System.Collections.Generic;

namespace Ninja1.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            //this.Seed();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<StoreViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public StoreViewModel Store
        {
            get
            {
                return ServiceLocator.Current.GetInstance<StoreViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }


        public void Seed()
        {
            NinjaContext nc = new NinjaContext();
            UserRepository userRepository = new UserRepository(nc);
            CategoryRepository cr = new CategoryRepository(nc);
            EquipmentRepository er = new EquipmentRepository(nc);

            IEnumerable<Ninja_User> users = userRepository.GetAllUser();
            nc.Equipment.RemoveRange(nc.Equipment);
            IEnumerable<Equipment> eqsl = er.GetAllEquipment();
            foreach(Ninja_User u in users)
            {
                userRepository.Delete(u.id);
                userRepository.Save();
            }
            

            EquipmentCategory ec = new EquipmentCategory();
            ec.name = "Helmet";
            cr.CreateCategory(ec);
            ec = new EquipmentCategory();
            ec.name = "Body Armor";
            cr.CreateCategory(ec);
            cr.Save();

            Equipment e = new Equipment();
            e.agility = 100;
            e.categorie = cr.GetCategory(0);
            e.intelligence = 100;
            e.strength = 100;
            e.name = "Dark Helmet";
            er.CreateEquipment(e);

            e = new Equipment();
            e.agility = 100;
            e.categorie = cr.GetCategory(1);
            e.intelligence = 100;
            e.strength = 100;
            e.name = "Awesome Body Armor";
            er.CreateEquipment(e);
            er.Save();

            List<Equipment> equip = new List<Equipment>();
            equip.Add(er.GetEquipment(0));
            equip.Add(er.GetEquipment(1));

            Ninja_User nu = new Ninja_User();
            nu.name = "MyName123";
            nu.gold = 100;
            nu.boughtEquipment = equip;
            nu.currentEquipment = equip;
            nu.id = 1;

            userRepository.CreateUser(nu);
            userRepository.Save();

            
        }
    }
}