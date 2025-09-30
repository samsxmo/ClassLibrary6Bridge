using ClassLibrary6;


namespace MCUnitTest
{
    public sealed class McTests
    {
        [Fact]
        public void Price_ShouldReturnFixedValue()
        {
            var mc = new MC("BX80555", DateTime.Now,false);
            Assert.Equal(120.0, mc.Price(), 0.001);
        }

        [Fact]
        public void Vehicle_ShouldReturnMC()
        {
            var mc = new MC("BX80555", DateTime.Now, true);
            Assert.Equal("MC", mc.VehicleType());
        }
    }
}