using OresundTicketLibrary;
using Xunit;


public sealed class OresundTicketLibraryTest
{
    [Fact]
    public void Price_WithoutBrobizz_ShouldBe460()
    {
        var car = new OresundCar("CA67886", DateTime.Now, false);
        Assert.Equal(460.0, car.Price());
    }

    [Fact]
    public void Price_WithBrobizz_ShouldBe178()
    {
        var car = new OresundCar("CA67886", DateTime.Now, true);
        Assert.Equal(178.0, car.Price());
    }

    [Fact]
    public void VehicleType_ShouldReturnOresundCar()
    {
        var car = new OresundCar("CA67886", DateTime.Now, false);
        Assert.Equal("Oresund car", car.VehicleType());
    }
}