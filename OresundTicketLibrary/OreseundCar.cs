using StorebæltLibrary;
using System;
using ClassLibrary6;

namespace OresundTicketLibrary;

public class OresundCar : Vehicle
{
    public OresundCar(string licenseplate, DateTime date, bool hasBrobizz)
        : base(licenseplate, date, hasBrobizz) {}

    public override double Price()
    {
        return HasBrobizz ? 178 : 460; // Brobizz er allerede indregnet
    }

    public override string VehicleType()
    {
        return "Oresund car";
    }
}
