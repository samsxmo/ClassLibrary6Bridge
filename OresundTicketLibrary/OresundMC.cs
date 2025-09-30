using StorebæltLibrary;
using System;
using ClassLibrary6;

namespace OresundTicketLibrary;

public class OresundMC : Vehicle
{ 
 public OresundMC(string licenseplate, DateTime date, bool hasBrobizz)
        : base(licenseplate, date, hasBrobizz) {}

public override double Price()
{ 
    return HasBrobizz ? 92.0 : 235.0;
}

    public override string VehicleType()
    {
        return "Oresund MC";
    }
}
