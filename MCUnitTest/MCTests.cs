using ClassLibrary6;


namespace MCUnitTest
{
    public sealed class MCUnirests
    {
        [Fact]
        public void Price_ShouldReturnFixedValue120()
        {
            var mc = new MC("BX80555", DateTime.Now,false);
            Assert.Equal(120.0, mc.Price());
        }

        [Fact]
        public void Vehicle_ShouldReturnMC()
        {
            var mc = new MC("BX80555", DateTime.Now, true);
            Assert.Equal("MC", mc.VehicleType());
        }
        [Fact]
        public void Price_WithBrobizz_ShouldApply10PercentDiscount()
        {
            var mc = new MC("BX80555", DateTime.Now,false) { BrobizzUsed = true };

            Assert.Equal(108.0, mc.Price(), 2); // 120 * 0.9
        }
    }
}