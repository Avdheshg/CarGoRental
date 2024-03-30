using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation.AddonServices
{
    public class OnDemandTowing : AddonService
    {
        public OnDemandTowing(string id, string name, string desciption, double cost)
        {
            Id = id;
            Name = name;
            Description = desciption;
            Cost = cost;
        }
    }
}
