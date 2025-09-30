using System;
using ClassLibrary6;
using StorebæltLibrary;

namespace StorebæltLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class TicketLibrary : Car
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <param name="licensePlate"></param>
        /// <param name="hasBrobizz"></param>
        /// <param name="date"></param>
        /// <exception cref="ArgumentException"></exception>
        public TicketLibrary(string vehicleType, string licensePlate, bool hasBrobizz, DateTime date)
            : base(licensePlate, date, hasBrobizz)
        {
            
            if (licensePlate.Length > 7)
                throw new ArgumentException("Licenseplate cannot be longer than 7 characters.");
            
            Licenseplate = licensePlate;
            HasBrobizz = hasBrobizz;
            Date = date;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double basePrice = 230;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // 15% weekendrabat
            }

            return ApplyBrobizzDiscount(basePrice); // Brobizz-rabat bagefter
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}


  
    
        