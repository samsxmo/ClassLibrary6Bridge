using System;
using ClassLibrary6;
using StorebæltLibrary;

namespace StorebæltLibrary
{
    public class TicketLibrary : Car
    {
        public TicketLibrary(string vehicleType, string licenseplate, bool brobizzUsed, DateTime date)
            : base(licenseplate, date, brobizzUsed)
        {
        }

        public override double Price()
        {
            double basePrice = 230;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // 15% weekendrabat
            }

            return ApplyBrobizzDiscount(basePrice); // Brobizz-rabat bagefter
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}


  
    
        