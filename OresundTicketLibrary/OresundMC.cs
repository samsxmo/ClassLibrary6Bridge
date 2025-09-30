using StorebæltLibrary;
using System;
using ClassLibrary6;

namespace OresundTicketLibrary;

public class OresundMC : Vehicle
{
    public OresundMC(string licenseplate, DateTime date, bool brobizzUsed)
        : base(licenseplate, date, brobizzUsed) {}

    protected override double GetBasePrice()
    {
        return BrobizzUsed ? 92.0 : 235.0;
    }

    public override string VehicleType()
    {
        return "Oresund MC";
    }
}
