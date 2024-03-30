﻿using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation
{
    public class ReservationReminder
    {
        public DateTime ReservationDate { get; set; }
        public string ReservationId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public NotificationStatusType NotificationStatusType { get; set; }
    }
}
