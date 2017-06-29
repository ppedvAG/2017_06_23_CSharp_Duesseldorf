using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Levante.Core;
using Levante.Core.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace Levante.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRepository _repository;

        public MainViewModel(IRepository repository)
        {
            _repository = repository;
        }

        private IEnumerable<User> _users;
        public IEnumerable<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                RaisePropertyChanged();
            }
        }
        private User _selectedUser;
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                RaisePropertyChanged();
            }
        }


        private ICommand _initializeCommand;
        public ICommand InitializeCommand
        {
            get
            {
                return _initializeCommand ?? (_initializeCommand = new RelayCommand(
                    execute: () => Users = _repository.GetAll()));
            }
        }
    }
}