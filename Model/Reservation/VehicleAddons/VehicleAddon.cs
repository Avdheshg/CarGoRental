using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation.VehicleAddons
{
    public abstract class VehicleAddon
    {
        private string cost;
        //public string Id { get; }    // By this, V will not be able to access this in the child class and if V use the "set", then this will be accessible from anywhere and anybody can change the Id which is not desirable
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
    }
}
