using CarGoRental.Model.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Account
{
    public class Driver : Account
    {
        public LicenseInfo LicenseInfo { get; set; }
        public HireableVehicle DriverVehicle { get; }
        public DriverStatusType DriverStatusType { get; set; }

        public Driver(HireableVehicle driverVehicle, string email, string userName, string password, Contact contactDetails, string licenseNumber, DateTime issueDate, DateTime expiryDate, string issuedAtPlace, string issuedInState, string issuedInCountry, LicenseType licenseType) 
            : base(email, userName, password, AccountType.ADMIN, contactDetails)
        {
            DriverVehicle = driverVehicle;
            DriverStatusType = DriverStatusType.AVAILABLE;

            LicenseInfo = new LicenseInfo(licenseNumber, issueDate, expiryDate, issuedAtPlace, issuedInState, issuedInCountry, licenseType);
        }

        // price, car, address
        public void AcceptReservation(string price, Address startAddress ,Address destinationAddress) 
        {
            DriverStatusType = DriverStatusType.BUSY;
        }


    }
}
