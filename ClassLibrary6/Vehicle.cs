namespace ClassLibrary6;

/// <summary>
/// En abstrakt baseklasse for alle køretøjstyper, der definerer fælles egenskaber. 
/// </summary>
public abstract class Vehicle
{
    public string Licenseplate { get; set; }
    public DateTime Date  { get; set; }
    public bool HasBrobizz {get; set;}
    
    //Intilasering af properties
    protected Vehicle(string licenseplate, DateTime date,bool hasBrobizz)
    {
        if (licenseplate.Length < 7)
        {
            throw new ArgumentException("License plate cannot be longer than 7 characters.");
        }        
        Licenseplate = licenseplate;    
        Date = date;
        HasBrobizz = hasBrobizz;
    }
    

    public abstract string VehicleType();
    public abstract double Price();
    protected double ApplyBrobizzDiscount(double price)
    {
        return HasBrobizz ? price * 0.9 : price;
    }
}



