using Ninja1Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1.ViewModel
{
    class UserViewModel : INotifyPropertyChanged 
    {
        public int id 
        {
            get { return _user.id; }
            set { _user.id = value; OnPropertyChanged(); }
        }
        public string name 
        {
            get { return _user.name; }
            set { _user.name = value; OnPropertyChanged(); }
        }
        public int gold
        {
            get { return _user.gold; }
            set { _user.gold = value; OnPropertyChanged(); }
        }
        public List<Equipment> current_equipment 
        {
            get { return _user.current_equipment; }
            set { _user.current_equipment = value; OnPropertyChanged(); }
        }
        public List<Equipment> bought_equipment 
        {
            get { return _user.bought_equipment; }
            set { _user.bought_equipment = value; OnPropertyChanged(); }
        }

        private Ninja_User _user;

        public UserViewModel()
        {
            _user = new Ninja_User();
        }
        public UserViewModel(Ninja_User user)
        {
            _user = user;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
