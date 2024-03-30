using CarGoRental.Model.Account;
using CarGoRental.Model.Vehicle;
using CarGoRental.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarGoRental
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StartApplication();

            //MainViewModel mainViewModel = new MainViewModel();
            //DataContext = mainViewModel;
        }

        public void StartApplication()
        {   
            //HireableVehicle driver1Vehicle = new Car() 
            //Account driver1 = new Driver();
        } 

    }

/*
3 Major parts of this application:
    1. Vehicle
    2. Account
    3. Reservation

* Need a DB 
* Needs to implement the Repository and service as DB for Vehicles and User
* UI

* CarType: car, van, bike, truck, 
* Driver is having their own car/vehicle or
* Phone number will be considered as primary key


*/


}
