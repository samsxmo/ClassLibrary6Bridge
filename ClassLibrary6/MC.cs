namespace ClassLibrary6;

public class MC : Vehicle
{
    public MC(string licenseplate, DateTime date, bool hasBrobizz)
        : base(licenseplate, date, hasBrobizz)
    {
    }
    
    public override double Price()
    {
        double basePrice = 120.0;

        if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
        {
            basePrice *= 0.80; // 20% weekendrabat
        }
        return ApplyBrobizzDiscount(basePrice); // Brobizz-rabat bagefter
    }

    // Køretøjstype
    public override string VehicleType()
    {
        return "MC";
    }

}


