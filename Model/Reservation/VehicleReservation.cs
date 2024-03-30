using CarGoRental.Model.Account;
using CarGoRental.Model.Reservation.AddonServices;
using CarGoRental.Model.Reservation.VehicleAddons;
using CarGoRental.Model.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation
{
    public class VehicleReservation
    {
        public string ReservationId { get; }
        public string UserId { get; }
        public DateTime ReservationDate { get; }
        public ReservationStatusType ReservationStatusType { get; set;  }
        public DateTime FromDate { get; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Address PickupLocation { get; }
        public Address DropLocation { get; set; }
        public double StartMileage { get; set; }
        public double EndMileage { get; set ; }
        public HireableVehicle HireableVehicle { get; }
        public VehicleType VehicleType { get; }
        public string InvoiceId { get; set; }

        List<VehicleAddon> VehicleAddons { get; set; }
        List<AddonService> AddonServices { get; set; }

    }
}
