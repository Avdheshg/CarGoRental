using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarGoRental.Model.Common;

namespace CarGoRental.Model.Vehicle
{
/*
Every vehicle(Car, Van, Bike, Cycle) has some basic features like 
    1. Start
    2. Stop
    3. Turn left
    4. turn right
    5. go straight
    6. reverse
    7. Change gears - some bicycles don't have gears
*/
    public abstract class HireableVehicle 
    {
        #region fields

        private string _id;
        private string _licensePlateNumber;
        private string _maker;
        private string _model;
        private int _yearOfManufacture;       // which is better, string or int for this
        private int _numberOfSeats;
        private VehicleCategoryType _vehicleCategoryType;
        private VehicleType _vehicleType;

        #endregion

        #region Properties
        public string Id => GenerateId();
        public string LicensePlateNumber => GenerateLicensePlateNumber();   // cycles don't have LicensePlateNumber - what to do when cycle class will inherit 
        public string Maker => _maker;
        public string Model => _model;
        public int YearOfManufacture => _yearOfManufacture;
        public int NumberOfSeats => _numberOfSeats;
        public double Mileage {  get; set; }    // cycles don't have mileage - what to do when cycle class will inherit mileage
        public VehicleCategoryType VehicleCategoryType => _vehicleCategoryType;
        public VehicleStatusType VehicleStatusType { get; set; }
        public VehicleType VehicleType => _vehicleType;
        public VehicleLocation ParkedLocation { get; set; }
        public Coordinates CurrentLocation { get; set; }

        #endregion

        protected HireableVehicle(string licencePlateNumber, string maker, string model, int yearOfManufacture, double mileage, int numberOfSeats, VehicleCategoryType vehicleCategoryType, VehicleStatusType vehicleStatusType, VehicleType vehicleType, VehicleLocation parkedLocation = null)
        {
            _id = GenerateId();
            _licensePlateNumber = licencePlateNumber;
            _maker = maker;
            _model = model;
            _yearOfManufacture = yearOfManufacture;
            Mileage = mileage;
            _numberOfSeats = numberOfSeats;
            _vehicleCategoryType = vehicleCategoryType;
            VehicleStatusType = vehicleStatusType;
            _vehicleType = vehicleType;
            ParkedLocation = parkedLocation;
        }

        #region Utility functions

        public string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }

        public string GenerateLicensePlateNumber()
        {
            // Creating object of random class 
            Random rand = new Random();

            // Choosing the size of string 
            // Using Next() string 
            int stringlen = rand.Next(9, 10);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                // Generating a random number. 
                randValue = rand.Next(0, 26);

                // Generating random character by converting 
                // the random number into character. 
                letter = Convert.ToChar(randValue + 65);

                // Appending the letter to string. 
                str = str + letter;
            }
            return str;
        }

        #endregion

        #region vehicle generic functions
        public void Start(VehicleType vehicleType)
        {
            Console.WriteLine($"{vehicleType} started");
        }

        public void Stop(VehicleType vehicleType)
        {
            Console.WriteLine($"{vehicleType} stopped");
        }

        public void TurnLeft(VehicleType vehicleType)
        {
            Console.WriteLine($"{vehicleType} turned left");
        }
     
        public void TurnRight(VehicleType vehicleType)
        {
            Console.WriteLine($"{vehicleType} turned right");
        }

        public void GoStraight(VehicleType vehicleType)
        {
            Console.WriteLine($"{vehicleType} going straight");
        }

        public void Reverse(VehicleType vehicleType)
        {
            Console.WriteLine($"{vehicleType} going reverse");
        }

        public virtual void ChangeGears(VehicleType vehicleType, int gear)
        {
            Console.WriteLine($"{vehicleType} is running in {gear} gear");
        }

        #endregion


    }
}














