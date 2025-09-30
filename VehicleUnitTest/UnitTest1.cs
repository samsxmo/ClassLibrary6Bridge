using System;
using Xunit;
using ClassLibrary6;
namespace ClassLibrary6
{
    public sealed class VehicleTests
    {
        [Fact]
        public void VehicleBase_PolymorphicTests()
        {
            // Arrange
            var car = new Car("CA67886", DateTime.Now, false);
            var mC = new MC("BX80555", DateTime.Now, false);

            // Act
            var carPrice = car.Price();
            var mCPrice = mC.Price();
            var carType = car.VehicleType();
            var mCType = mC.VehicleType();

            // Assert
            Assert.Equal(230.0, carPrice);
            Assert.Equal(120.0, mCPrice);
            Assert.Equal("Car", carType);
            Assert.Equal("MC", mCType);
        }
    }
}

   