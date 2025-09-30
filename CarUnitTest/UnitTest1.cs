using ClassLibrary6;
using Xunit;
using System;

namespace CarUnitTest
{
    public class CarTests
    {
        //En test over at bilens pris uden rabat er 230 
        [Fact]
        public void Price_ShouldReturnFixedValue230()
        {
            var car = new Car("CA67886", DateTime.Now, false);
            Assert.Equal(230.0, car.Price());
        }

        [Fact]
        public void VehicleType_ShouldReturnCar()
        {
            var car = new Car("CA67886", DateTime.Now, true);
            Assert.Equal("Car", car.VehicleType());
        }
        [Fact]
        //Tester at brobizz giver 10% på bilens pris. 
        public void Price_WithBrobizz_ShouldApply10PercentDiscount()
        {
            var car = new Car("CA67886", DateTime.Now, true) { BrobizzUsed = true};

            Assert.Equal(207.0, car.Price(), 2); // 230 * 0.9
        }
    }

}
