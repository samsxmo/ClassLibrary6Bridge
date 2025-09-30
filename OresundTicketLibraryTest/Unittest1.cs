using OresundTicketLibrary;
using Xunit;
using System;


namespace OresundTicketLibraryTest
{
    public sealed class OresundVehicleTests
    {
        [Fact]
        public void OresundCar_WithoutBrobizz_ShouldBe460()
        {
            var car = new OresundCar("CA12345", DateTime.Now, false);
            Assert.Equal(460.0, car.Price());
        }

        [Fact]
        public void OresundCar_WithBrobizz_ShouldBe178()
        {
            var car = new OresundCar("CA12345", DateTime.Now, true);
            Assert.Equal(178.0, car.Price());
        }

        [Fact]
        public void OresundCar_Type_ShouldBeCorrect()
        {
            var car = new OresundCar("CA12345", DateTime.Now, false);
            Assert.Equal("Oresund car", car.VehicleType());
        }

        [Fact]
        public void OresundMC_WithoutBrobizz_ShouldBe235()
        {
            var mc = new OresundMC("MC12345", DateTime.Now, false);
            Assert.Equal(235.0, mc.Price());
        }

        [Fact]
        public void OresundMC_WithBrobizz_ShouldBe92()
        {
            var mc = new OresundMC("MC12345", DateTime.Now, true);
            Assert.Equal(92.0, mc.Price());
        }

        [Fact]
        public void OresundMC_Type_ShouldBeCorrect()
        {
            var mc = new OresundMC("MC12345", DateTime.Now, false);
            Assert.Equal("Oresund MC", mc.VehicleType());
        }
    }
}
