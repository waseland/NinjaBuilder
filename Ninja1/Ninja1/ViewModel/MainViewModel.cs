using GalaSoft.MvvmLight;
using Ninja1Context.Context;
using Ninja1Context.Models;
using Ninja1Context.Repositories;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ninja1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        

        UserViewModel uv;
        UserRepository userRepo;
        NinjaContext context;


        public string name
        {
            get { return uv.Name; }
            set { uv.Name = value; RaisePropertyChanged(); }
        }


        public int gold
        {
            get { return uv.Gold; }
            set { uv.Gold = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<Equipment> Equipment
        { 
            get { return new ObservableCollection<Equipment>(uv.current_equipment); } 
        }
        public int strength
        {
            get { return uv.strength;  }
        }
        public int agility
        {
            get { return uv.agility; }
        }
        public int intelligence
        {
            get { return uv.intelligence; }
        }

        

        public MainViewModel(int id)
        {
            context = new NinjaContext();
            userRepo = new UserRepository(context);

            IEnumerable<Ninja_User> naming = userRepo.GetAllUser();          
            Ninja_User turtle = userRepo.GetUser(id);
            uv = new UserViewModel(turtle);
        }


    }
}