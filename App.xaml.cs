using CarGoRental.Stores;
using CarGoRental.ViewModel;
using System.Windows;

namespace CarGoRental
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();

            //navigationStore.CurrentViewModel = new AccountTypeViewModel(navigationStore);
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);

        }
    }
}
