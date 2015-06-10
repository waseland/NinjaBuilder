
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
        private MainViewModel MainViewModel;

        public ViewModelLocator()
        {
            this.Seed();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<UserListViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<StoreViewModel>();
        }

        public UserListViewModel User
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserListViewModel>();
            }
        }

        public MainViewModel Main
        {
            get
            {
                return new MainViewModel(this.User.SelectedUser.id);
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
            ec = new EquipmentCategory();
            ec.name = "Shoes";
            cr.CreateCategory(ec);
            ec = new EquipmentCategory();
            ec.name = "Trousers";
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

            e = new Equipment();
            e.agility = 300;
            e.categorie = cr.GetCategory(2);
            e.intelligence = 300;
            e.strength = 300;
            e.name = "Awesome Shoes of Destiny";
            er.CreateEquipment(e);

            e = new Equipment();
            e.agility = 200;
            e.categorie = cr.GetCategory(3);
            e.intelligence = 500;
            e.strength = 200;
            e.name = "Awesome Trousers of Nudity";
            er.CreateEquipment(e);

            er.Save();

            List<Equipment> equip = new List<Equipment>();
            equip.Add(er.GetEquipment(0));
            equip.Add(er.GetEquipment(1));


            List<Equipment> equip2 = new List<Equipment>();
            equip2.Add(er.GetEquipment(2));
            equip2.Add(er.GetEquipment(3));

            Ninja_User nu = new Ninja_User();
            nu.name = "MyName123";
            nu.gold = 100;
            nu.boughtEquipment = equip;
            nu.currentEquipment = equip;
            nu.id = 1;
            userRepository.CreateUser(nu);
            nu = new Ninja_User();
            nu.name = "Jelmer";
            nu.gold = 1000;
            nu.boughtEquipment = equip2;
            nu.currentEquipment = equip2;
            nu.id = 2;
            userRepository.CreateUser(nu);
            //Ninja_User nu1 = new Ninja_User();
           // nu1.name = "Jelmer";
            //nu1.gold = 1000;
            //nu1.boughtEquipment = equip;
            //nu1.currentEquipment = equip;
            //nu1.id = 2;

            
            //userRepository.CreateUser(nu1);
            userRepository.Save();

            
        }
    }
}