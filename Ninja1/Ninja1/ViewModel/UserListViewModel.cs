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

namespace Ninja1.ViewModel
{
    class UserListviewModel :INotifyPropertyChanged
    {
        private NinjaContext DbContext;

        IUserRepository userRepository;

        private UserViewModel _userViewModel;

        public ObservableCollection<UserViewModel> Users { get; set; }

        private UserViewModel SelectedUser { get { return _userViewModel; }
            set
            {
                _userViewModel = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public UserListviewModel()
        {
            userRepository = new DummyUserRepository(DbContext);
            var userList = userRepository.ToList().Select(s => new UserViewModel(s));

            Users = new ObservableCollection<UserViewModel>(userList);

            SelectedUser = new UserViewModel();

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
