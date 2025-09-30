using ClassLibrary6;
using Xunit;
using System;

namespace CarUnitTest

{
    public class CarTests
    {
    // Test: Car pris uden Brobizz er 230
                      
        [Fact]
        public void Price_ShouldReturnFixedValue()
        {
            var car = new Car("CA67886", DateTime.Now, false);

            Assert.Equal(230.0, car.Price());

        }
        
        // Test: VehicleType retunere "Car"

        [Fact]

        public void VehicleType_ShouldReturnCar()

        {

            var car = new Car("CA67886", DateTime.Now, true);

            Assert.Equal("Car", car.VehicleType());

        }
        
        // Test: Car pris med Brobizz er 161
      
        [Fact]
        public void Price_WithBrobizz_ShouldReturnDiscountedValue()
      
        {
            var car = new Car("CA67886", DateTime.Now, true);
      
            Assert.Equal(230.0, car.Price());
      
        }
        
        // Test: License plate længere end 7 characters throws exception
      
        [Fact]
      
        public void Licenseplate_TooLong_ShouldThrowException()
      
        {

            var longLicensePlate = "THISLICENSEPLATEISTOOLONG";

            var exception = Assert.Throws<ArgumentException>(() => new Car(longLicensePlate, DateTime.Now, false));

            Assert.Equal("License plate cannot be longer than 7 characters.", exception.Message);
                                                                
        }

    }

}




