using CarGoRental.Model.Reservation;
using CarGoRental.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Service
{
/*
Functions of ReservationService:
    1. Create reservation
    2. Delete reservation
    3. Update reservation
    4. Get reservation details
*/
    public class ReservationService
    {
        private ReservationRepository _reservationRepository;

        public void CreateNewReservation(VehicleReservation vehicleReservation)
        {
            _reservationRepository.CreateNewReservation(vehicleReservation);
        }

        public void DeleteReservation(string reservationId)
        {
            _reservationRepository.DeleteReservation(reservationId);
        }

        public void UpdateReservation(string reservationToUpdateId, VehicleReservation updatedVehicleReservation)
        {
            _reservationRepository.UpdateReservation(reservationToUpdateId, updatedVehicleReservation);
        }

        public void GetReservationOfDriver(string driverId)
        {
            _reservationRepository.GetReservationOfDriver(driverId);
        }

        public void GetreservationOfUser(string userId)
        {
            _reservationRepository.GetReservationOfUser(userId);
        }

    }
}
