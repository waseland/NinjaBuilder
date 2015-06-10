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

namespace Ninja1.ViewModel
{
    public class UserListViewModel : ViewModelBase
    {

        UserRepository userRepo;
        NinjaContext DbContext;

        private UserViewModel _userViewModel;

        public ObservableCollection<UserViewModel> Users { get; set; }

        public ICommand GoToNinjaCommand { get; set; }

        public UserViewModel SelectedUser
        {
            get { return _userViewModel; }
            set
            {
                _userViewModel = value;
                RaisePropertyChanged("SelectedUser");
            }
        }

        public UserListViewModel()
        {
           DbContext = new NinjaContext();
           userRepo = new UserRepository(DbContext);
           var userList = userRepo.GetAllUser().ToList().Select(s => new UserViewModel(s));

            Users = new ObservableCollection<UserViewModel>(userList);
            SelectedUser = new UserViewModel();

            GoToNinjaCommand = new RelayCommand(GoToNinja);

        }

        public void GoToNinja()
        {
            var ninjaDetails = new MainWindow();
            ninjaDetails.Show();
        }

    }
}
