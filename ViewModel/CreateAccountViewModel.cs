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
    public class CreateAccountViewModel : ViewModelBase
    {
        public string Message => "Create an Account";

        public ICommand NavigateCreateAccountCommand { get; }

        public CreateAccountViewModel(NavigationStore navigationStore)
        {
            NavigateCreateAccountCommand = new NavigateCreateAccountCommand(navigationStore);
        }

    }
}
