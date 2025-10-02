namespace ClassLibrary6;

public class Car : Vehicle
{
    public Car(string licenseplate, DateTime date, bool hasBrobizz)
        : base(licenseplate, date, hasBrobizz)
    {
        if (string.IsNullOrEmpty(licenseplate))
            throw new ArgumentException("License plate cannot be empty.");
        if (licenseplate.Length > 7)
            throw new ArgumentException("License plate cannot be longer than 7 characters.");
    }
    
   // Grundpris for Car
   
   public override double Price() => 230.0;

    // Køretøjstype
    public override string VehicleType() => "Car";

    
    
}
