using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation.VehicleAddons
{
    public class PassengerScreen : VehicleAddon
    {
        public PassengerScreen(string id, string name, string description, double cost)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
}
