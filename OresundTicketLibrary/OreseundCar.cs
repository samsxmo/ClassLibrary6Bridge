using StorebæltLibrary;
using System;
using ClassLibrary6;

namespace OresundTicketLibrary;
    public class OresundCar : Vehicle
    {
        public OresundCar(string licenseplate, DateTime date, bool brobizzUsed)
            : base(licenseplate, date, brobizzUsed) {}

        public override double Price()
        {
            return GetBasePrice(); // Brobizz er allerede indregnet
        }
        
       protected override double GetBasePrice()
        {
            return BrobizzUsed ? 178.0 : 460.0;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }

       
    }

