﻿namespace lab1.Entities.VehicleRealisations;

class Broom() : AirVehicle("Broom", 25.0)
{
    protected override double GetSpeedRaise(double distance)
    {
        return 25 / distance;
    }
}