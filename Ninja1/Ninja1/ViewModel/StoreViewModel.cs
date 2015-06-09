using GalaSoft.MvvmLight;
using Ninja1Context.Context;
using Ninja1Context.Models;
using Ninja1Context.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Ninja1.ViewModel
{
    public class StoreViewModel : ViewModelBase
    {
        NinjaContext nc;
        EquipmentViewModel ev;
        CategoryRepository cr;

        public ObservableCollection<EquipmentCategory> categorys
        {
            get { return new ObservableCollection<EquipmentCategory>(cr.GetAllCategory()); }
        }

        private EquipmentCategory _selectedCategory;

        public EquipmentCategory SelectedCategory
        {
            get
            {
                return _selectedCategory;
            }
            set
            {
                _selectedCategory = value;
                RaisePropertyChanged();
            }
        }

        //public ObservableCollection<Equipment> categorys
        //{
        //    get { return new ObservableCollection<EquipmentCategory>(cr.GetAllCategory()); }
        //}

        //private EquipmentCategory _selectedCategory;

        //public EquipmentCategory SelectedCategory
        //{
        //    get
        //    {
        //        return _selectedCategory;
        //    }
        //    set
        //    {
        //        _selectedCategory = value;
        //        RaisePropertyChanged();
        //    }
        //}



        public StoreViewModel()
        {
            nc = new NinjaContext();
            cr = new CategoryRepository(nc);
            ev = new EquipmentViewModel();
        }

    }
}
