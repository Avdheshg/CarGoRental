using CarGoRental.Stores;
using CarGoRental.ViewModel;
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

        public NavigateAccountTypeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new AccountTypeViewModel(_navigationStore);
        }
    }
}
