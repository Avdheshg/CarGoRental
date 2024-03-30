using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Reservation.AddonServices
{
    public class Chauffeur : AddonService
    {
        public Chauffeur(string id, string name, string description, double cost)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
}
