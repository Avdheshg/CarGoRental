using CarGoRental.Commands;
using CarGoRental.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarGoRental.ViewModel
{
    public class AccountTypeViewModel : ViewModelBase
    {
        public string Name => "Select Account Type";

        public ICommand NavigateHomeCommand { get; }

        public AccountTypeViewModel(NavigationStore navigationStore)
        {
            // NavigateHomeCommand = new NavigateHomeCommand(navigationStore);
            NavigateHomeCommand = new NavigateCreateAccountCommand(navigationStore);
        }


    }
}
