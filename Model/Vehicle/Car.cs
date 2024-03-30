using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Vehicle
{

/*
Behaviuors a car can have:
    
*/
    public class Car : HireableVehicle
    {
        public Car(string licencePlateNumber, string maker, string model, int yearOfManufacture, double mileage, int numberOfSeats, VehicleCategoryType vehicleCategoryType, VehicleStatusType vehicleStatusType, VehicleType vehicleType, VehicleLocation parkedLocation)
            : base (licencePlateNumber, maker, model, yearOfManufacture, mileage, numberOfSeats, vehicleCategoryType, vehicleStatusType, vehicleType, parkedLocation)
        {
            
        }
    }
}
