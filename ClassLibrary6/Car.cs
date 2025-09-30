namespace ClassLibrary6;

public class Car : Vehicle
{
    public Car(string licenseplate, DateTime date, bool brobizzUsed)
        : base(licenseplate, date, brobizzUsed)
    {
        if (string.IsNullOrEmpty(licenseplate))
            throw new ArgumentException("License plate cannot be empty.");
        if (licenseplate.Length > 7)
            throw new ArgumentException("License plate cannot be longer than 7 digits.");
    }
//public override double Price()
    //{
       // return 230.0;
   // }


    //public override string VehicleType()
    //{
        //return "Car";
   // }
    
   // Grundpris for Car
   
   public override double Price() => 230.0;

    // Køretøjstype
    public override string VehicleType() => "Car";

    
    
}
