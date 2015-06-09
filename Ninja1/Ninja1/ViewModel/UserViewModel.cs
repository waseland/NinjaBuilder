using Ninja1Context.Context;
using Ninja1Context.Models;
using Ninja1Context.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ninja1.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged 
    {

        private Ninja_User _user;

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


        public ICollection<Equipment> current_equipment 
        {
            get { return _user.currentEquipment; }
            set { _user.currentEquipment = value; OnPropertyChanged(); }
        }

        public int strength
        {
            get { return calculateTotalStrength(); }
        }

        public int intelligence
        {
            get { return calculateTotalIntelligence(); }
        }

        public int agility
        {
            get { return calculateTotalAgility(); }
        }


        public ICollection<Equipment> bought_equipment 
        {
            get { return _user.boughtEquipment; }
            set { _user.boughtEquipment = value; OnPropertyChanged(); }
        }

        public UserViewModel(Ninja_User user)
        {
            _user = user;
        }

        public int calculateTotalStrength()
        {
            int strenght = 0;
            if(this.current_equipment != null)
            {
                foreach (Equipment q in this.current_equipment)
                {
                    strenght += q.strength;
                }
            }
            return strenght;
        }

        public int calculateTotalIntelligence()
        {
            int intelligence = 0;
            if (this.current_equipment != null)
            {
                foreach (Equipment q in this.current_equipment)
                {
                    intelligence += q.intelligence;
                }
            }
            return intelligence;
        }

        public int calculateTotalAgility()
        {
            int agility = 0;
            if (this.current_equipment != null)
            {
                foreach (Equipment q in this.current_equipment)
                {
                    agility += q.agility;
                }
            }
            return agility;
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
