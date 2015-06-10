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
        EquipmentRepository er;
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

                ObservableCollection<Equipment> gear = new ObservableCollection<Equipment>();
                foreach (Equipment a in er.GetAllEquipment())
                {
                    if (a.categorie.name == SelectedCategory.name)
                    {
                        gear.Add(a);
                    }
                }
                this.Equipments = gear;
            }
        }

        private ObservableCollection<Equipment> _equipments;

        public ObservableCollection<Equipment> Equipments
        {
            get { return _equipments; }
            set {   _equipments = value;
                    RaisePropertyChanged();
                }

        }

        private Equipment _selectedEquipment;

        public Equipment SelectedEquipment
        {
            get
            {
                return _selectedEquipment;
            }
            set
            {
                _selectedEquipment = value;
                RaisePropertyChanged();
            }
        }



        public StoreViewModel()
        {
            nc = new NinjaContext();
            cr = new CategoryRepository(nc);
            ev = new EquipmentViewModel();
            er = new EquipmentRepository(nc);
        }

    }
}
