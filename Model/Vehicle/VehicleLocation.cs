using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CarGoRental.Model.Common;

namespace CarGoRental.Model.Vehicle
{
    public class VehicleLocation
    {
        public string LocationId { get; }
        public Address Address {  get; }
        public Coordinates Coordinates { get; }
    }
}
