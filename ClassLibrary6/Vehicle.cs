namespace ClassLibrary6;

public abstract class Vehicle
{
    public string Licenseplate { get; set; }
    public DateTime Date  { get; set; }
    public bool BrobizzUsed {get; set;}
    protected Vehicle(string licenseplate, DateTime date,bool brobizzUsed)
    {
        if (licenseplate.Length < 7)
        {
            throw new Exception("Licenseplate must be at least 7 digits");
        }        
        Licenseplate = licenseplate;    
        Date = date;
        BrobizzUsed = brobizzUsed;
    
    }
    public virtual double Price()
    {
        
        double basePrice = GetBasePrice();
        return BrobizzUsed ? basePrice * 0.9 : basePrice;
    }

    //public abstract double Price();
    public abstract string VehicleType();
    protected abstract double GetBasePrice();
    protected double ApplyBrobizzDiscount(double price)
    {
        return BrobizzUsed ? price * 0.9 : price;
    }
}



