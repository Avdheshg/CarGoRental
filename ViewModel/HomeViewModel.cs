using CarGoRental.Commands;
using CarGoRental.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace CarGoRental.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public string Message => "Please sign in";

        public ICommand NavigateAccountTypeCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountTypeCommand = new NavigateAccountTypeCommand(navigationStore);
        }

    }
}
