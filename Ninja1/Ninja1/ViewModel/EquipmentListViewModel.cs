using Ninja1Context.Models;
using Ninja1Context.Repositories;
using Ninja1Context.Context;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace Ninja1.ViewModel
{
    public class EquipmentListViewModel : ViewModelBase
    {

        EquipmentRepository equipmentRepo;
        CategoryRepository categoryRepo;
        NinjaContext DbContext;

        private EquipmentViewModel _equipmentViewModel;

        private Equipment _equipment;

        private int _categorie;

        public ObservableCollection<EquipmentViewModel> Equipments { get; set; }
        public ObservableCollection<CategoryViewModel> Categories { get; set; }

        public ICommand NewEquipmentCommand { get; set; }

        public ICommand CreateEquipmentCommand { get; set; }

        public Equipment aNewEquipment
        {
            get { return _equipment; }
            set
            {
                _equipment = value;
                RaisePropertyChanged("aNewEquipment");
            }
        }
        public int aNewCategorie
        {
            get { return _categorie; }
            set
            {
                _categorie = value;
                RaisePropertyChanged("aNewCategorie");
            }
        }

        public EquipmentViewModel SelectedEquipment
        {
            get { return _equipmentViewModel; }
            set
            {
                _equipmentViewModel = value;
                RaisePropertyChanged("SelectedUser");
            }
        }

        public EquipmentListViewModel()
        {
            DbContext = new NinjaContext();
            equipmentRepo = new EquipmentRepository(DbContext);
            var equipmentList = equipmentRepo.GetAllEquipment().ToList().Select(s => new EquipmentViewModel(s));
            categoryRepo = new CategoryRepository(DbContext);
            var categoryList = categoryRepo.GetAllCategory().ToList().Select(s => new CategoryViewModel(s));

            Equipments = new ObservableCollection<EquipmentViewModel>(equipmentList);
            Categories = new ObservableCollection<CategoryViewModel>(categoryList);
            SelectedEquipment = new EquipmentViewModel();
            aNewEquipment = new Equipment();

            NewEquipmentCommand = new RelayCommand(NewEquipment);
            CreateEquipmentCommand = new RelayCommand(CreateEquipment);
        }

        public void NewEquipment()
        {
            var newEquipment = new NewEquipment();
            newEquipment.Show();

        }
        public void CreateEquipment()
        {
            Equipment e = new Equipment();

            e.name = aNewEquipment.name;
            e.strength = aNewEquipment.strength;
            e.intelligence = aNewEquipment.intelligence;
            e.agility = aNewEquipment.agility;
            e.categorie = categoryRepo.GetCategory(aNewCategorie + 1);
           // Equipment createEquipment = new Equipment(name, strength, intelligence, agility, categorie);
            equipmentRepo.CreateEquipment(e);
            equipmentRepo.Save();          

        }

    }
}
