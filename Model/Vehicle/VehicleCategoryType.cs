using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Vehicle
{
    public enum VehicleCategoryType
    {
        PASSENGER,
        COMMERCIAL
    }
}


/*
Every vehicle(Car, Van, Bike, Cycle) has some basic features like 
    1. Start
    2. Stop
    3. Turn left
    4. turn right
    5. go straight
    6. reverse
    7. Change gears - some bicycles don't have gears
*/