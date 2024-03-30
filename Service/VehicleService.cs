using CarGoRental.Model.Account;
using CarGoRental.Model.Vehicle;
using CarGoRental.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Service
{   
/*
This class provides, features:
    1. Adding a vehicle
    2. Removing a vehicle
    3. Changing the VehicleStatusType - Available, Booked
    4. Get all vehicles
*/
    public class VehicleService
    {
        private VehicleRepository _vehicleRepository;

        public void AddNewVehicle(HireableVehicle driverVehicle)
        {
            _vehicleRepository.AddNewVehicle(driverVehicle);
        }

        public void RemoveVehicle(Guid vehicleId)
        {
            _vehicleRepository.RemoveVehicle(vehicleId);
        }

        private Guid GetVehicleId(Account driverAccount, HireableVehicle driverVehicle)
        {
            return _vehicleRepository.GetVehicleId(driverAccount, driverVehicle);
        }

        public void ChangeVehicleStatus(Guid vehicleId, VehicleStatusType vehicleStatusType)
        {
            _vehicleRepository.ChangeVehicleStatusType(vehicleId, vehicleStatusType);
        }

        public List<HireableVehicle> GetAllVehicles()
        {
            return _vehicleRepository.GetAllVehicles();
        }

    }
}
