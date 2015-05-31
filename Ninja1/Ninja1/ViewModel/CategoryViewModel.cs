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
    class CategoryViewModel : INotifyPropertyChanged
    {
        private EquipmentCategory _category;

        public int id
        {
            get { return _category.id; }
            set { _category.id = value; OnPropertyChanged(); }
        }

        public string name
        {
            get { return _category.name; }
            set { _category.name = value; OnPropertyChanged(); }
        }

        public CategoryViewModel()
        {
            _category = new EquipmentCategory();
        }

        public CategoryViewModel(EquipmentCategory equipmentCategory)
        {
            _category = equipmentCategory;
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
