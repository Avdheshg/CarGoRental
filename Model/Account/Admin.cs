using CarGoRental.Model.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Account
{
/*
    Admin : Can change the AccountStatus of the user and driver
                - When the account status is changed, then the user and the driver must be having some restrictions wrt their status
                    - When the account is
                        Blacklisted: drivers will be notified that this user is blacklisted
                        Blocked: user/driver will not be able to book and booking for a month
                        Closed: The user will be deleted from the DB
            Can add or remove vehicles  
*/
    public class Admin : Account
    {
        public Admin(string email, string userName, string password, Contact contactDetails)
            : base (email, userName, password, AccountType.ADMIN, contactDetails)
        {
            
        }

        #region Utility function
        public string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }

        #endregion

        public void ChangeAccountStatusOfUser(User user, AccountStatusType accountStatusType)
        {
            switch (accountStatusType)
            {
                case AccountStatusType.BLACKLISTED:
                    user.AccountStatusType = accountStatusType;
                    break;
                case AccountStatusType.BLOCKED:
                    user.AccountStatusType = accountStatusType;
                    break;
                case AccountStatusType.CLOSED:
                    user.AccountStatusType = accountStatusType;
                    break;
            }
        }

        public void ChangeAccountStatusOfDriver(Driver driver, AccountStatusType accountStatusType)
        {
            switch (accountStatusType)
            {
                case AccountStatusType.BLACKLISTED:
                    break;
                case AccountStatusType.BLOCKED:
                    break;
                case AccountStatusType.CLOSED:
                    break;
            }
        }

        public void AddVehicle(VehicleType vehicleType, HireableVehicle vehicle)
        {
            switch (vehicleType)
            {
                case VehicleType.HATCHBACK:
                case VehicleType.SUV:
                    // vehicle as Car.AddCar => create the DB and write the code for adding and deleting in the vehicle
                case VehicleType.SEDAN:
                    break;
                case VehicleType.THREEWHEELER:
                    break;
                case VehicleType.TRUCK:
                    break;
                case VehicleType.VAN:
                    break;
                case VehicleType.MOTORCYCLE:
                    break;
                case VehicleType.BICYCLE:
                    break;

            }
        }

        public void RemoveVehicle(VehicleType vehicleType, HireableVehicle vehicle)
        {
            switch (vehicleType)
            {
                case VehicleType.HATCHBACK:
                    break;
                case VehicleType.SUV:
                    break;
                case VehicleType.SEDAN:
                    break;
                case VehicleType.THREEWHEELER:
                    break;
                case VehicleType.TRUCK:
                    break;
                case VehicleType.MOTORCYCLE:
                    break;
                case VehicleType.BICYCLE:
                    break;
            }
        }

    }
}
