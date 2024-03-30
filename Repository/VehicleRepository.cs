using CarGoRental.Model.Account;
using CarGoRental.Model.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Repository
{
    public class VehicleRepository
    {
        public void AddNewVehicle(HireableVehicle newVehicle)
        {
            // add new vehicle to DB
        }

        public void RemoveVehicle(Guid vehicleId) 
        {
        
        }

        public Guid GetVehicleId(Account driverAccount, HireableVehicle driverVehicle)
        {
            return Guid.Empty;
        }

        public void ChangeVehicleStatusType(Guid vehicleId, VehicleStatusType vehicleStatusType)
        {

        }

        public List<HireableVehicle> GetAllVehicles()
        {
            return new List<HireableVehicle>();
        }

    }
}
