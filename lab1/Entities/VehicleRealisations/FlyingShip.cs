﻿using System;

namespace lab1.Entities.VehicleRealisations;

class FlyingShip() : AirVehicle("Flying Ship", 3.0)
{
    protected override double GetSpeedRaise(double distance)
    {
        return Math.Log10(distance);
    }
}