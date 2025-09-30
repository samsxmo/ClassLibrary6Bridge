namespace ClassLibrary6;

public class MC : Vehicle
{
    public MC(string licenseplate, DateTime date, bool brobizzUsed)
        : base(licenseplate, date, brobizzUsed)
    {
    }

    //protected override double GetBasePrice()
    //{
      //return 120.0;
   // }
    

    //public override string VehicleType()
    //{
    //return "MC";
    //}

    protected override double GetBasePrice() => 120.0;

    // Køretøjstype
    public override string VehicleType() => "MC";

}


