using CarGoRental.Stores;
using CarGoRental.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Commands
{
    public class NavigateCreateAccountCommand : CommandBase
    {   
        private readonly NavigationStore _navigationStore;

        public NavigateCreateAccountCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new CreateAccountViewModel(_navigationStore);
        }
    }
}
