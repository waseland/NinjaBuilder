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
    class EquipmentViewModel : INotifyPropertyChanged 
    {
        public int id
        {
            get { return _equipment.id; }
            set { _equipment.id = value; OnPropertyChanged(); }
        }

        public string name
        {
            get { return _equipment.name; }
            set { _equipment.name = value; OnPropertyChanged(); }
        }

        public int strength 
        {
            get { return _equipment.strength; }
            set { _equipment.strength = value; OnPropertyChanged(); }
        }

        public int intelligence
        {
            get { return _equipment.intelligence; }
            set { _equipment.intelligence = value; OnPropertyChanged(); }
        }

        public int agility
        {
            get { return _equipment.agility; }
            set { _equipment.agility = value; OnPropertyChanged(); }
        }

        public EquipmentCategory categorie 
        {
            get { return _equipment.categorie; }
            set { _equipment.categorie = value; OnPropertyChanged(); }
        }

        private Equipment _equipment;

        public EquipmentViewModel()
        {
        }

        public EquipmentViewModel(Equipment equipment)
        {
            _equipment = equipment;
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
