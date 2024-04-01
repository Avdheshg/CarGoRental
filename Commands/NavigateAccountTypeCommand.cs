using CarGoRental.Model.Account;
using CarGoRental.Service;
using CarGoRental.Stores;
using CarGoRental.ViewModel;
using CarGoRental.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Commands
{
    public class NavigateAccountTypeCommand : CommandBase
    {   

        private readonly NavigationStore _navigationStore;

        private readonly HomeView _homeView;

        private readonly AccountService _accountService;

        public NavigateAccountTypeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new AccountTypeViewModel(_navigationStore);

            CreateNewAccount();
        }

        private void CreateNewAccount()
        {
            // string email, string userName, string password, AccountType accountType, Contact contact
            //Account account = new Account(_homeView.FullName, _homeView.Email, _homeView.Password, _homeView.Phone, _homeView.Address);

        }
    }
}
