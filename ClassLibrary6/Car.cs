namespace ClassLibrary6;

public class Car: Vehicle
{
    public Car(string licenseplate, DateTime date, bool brobizzUsed)
        : base(licenseplate, date, brobizzUsed){}

    //public override double Price()
    //{
       // return 230.0;
   // }


    //public override string VehicleType()
    //{
        //return "Car";
   // }
    
   // Grundpris for Car
    protected override double GetBasePrice() => 230.0;

    // Køretøjstype
    public override string VehicleType() => "Car";

    
    
}
