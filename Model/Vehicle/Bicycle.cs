using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Vehicle
{
    public class Bicycle : HireableVehicle
    {
        public Bicycle(string licencePlateNumber, string maker, string model, int yearOfManufacture, double mileage, int numberOfSeats, VehicleCategoryType vehicleCategoryType, VehicleStatusType vehicleStatusType, VehicleType vehicleType, VehicleLocation parkedLocation)
            : base (licencePlateNumber, maker, model, yearOfManufacture, mileage, numberOfSeats, vehicleCategoryType, vehicleStatusType, vehicleType, parkedLocation)
        {
            
        }

        public override void ChangeGears(VehicleType vehicleType, int gear = 0)
        {
            Console.WriteLine($"We don't serve gear bicycles");
        }
    }
}
