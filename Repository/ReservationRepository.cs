using CarGoRental.Model.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Repository
{
    public class ReservationRepository
    {
        List<VehicleReservation> vehicleReservations = new List<VehicleReservation>();

        public void CreateNewReservation(VehicleReservation reservation)
        {
            vehicleReservations.Add(reservation);
        }

        public void DeleteReservation(string reservationId)
        {
            foreach (VehicleReservation res in  vehicleReservations)
            {
                if (res.ReservationId.Equals(reservationId))
                {
                    vehicleReservations.Remove(res);
                    break;
                }
            }
        }

        public void UpdateReservation(string reservationToUpdateId, VehicleReservation updatedReservation)
        {
            var index = vehicleReservations.FindIndex(currReservation => currReservation.ReservationId.Equals(reservationToUpdateId));

            vehicleReservations[index] = updatedReservation;
        }

        public List<VehicleReservation> GetReservationOfDriver(string driverId)
        {
            return null;
        }

        public List<VehicleReservation> GetReservationOfUser(string userId)
        {
            return null;
        }

    }
}
