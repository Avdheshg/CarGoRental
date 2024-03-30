using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public string ReservationId { get; set; }
        public string UserId { get; set; }
        public double UserCharges { get; set; }
        public double AddonCost { get; set; }
        public double AddonServiceCost { get; set; }
        public double Taxes {  get; set; }
        public double Total {  get; set; }
    }
}
