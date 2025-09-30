using ClassLibrary6;
using StorebaeltLibrary;

namespace StorebaeltTicketLibraryTest
{
    public class TicketRepositoryTests
    {
        private ITicketRepository _repository;

        public TicketRepositoryTests()
        {
            _repository = new TicketRepository();
        }

        [Fact]
        public void AddVehicle_ShouldIncreaseCount()
        {
            var car = new TicketLibrary("Car","CA12345",  true, DateTime.Now);
            _repository.AddTicket(car);
            var all = _repository.GetAllTickets();
            Assert.Single(all);
        }

        [Fact]
        public void GetTicketsByLicenseplate_ShouldReturnAllAdded()
        {
            var car = new TicketLibrary("Car","CA12345",true, DateTime.Now);
            var mC = new TicketLibrary("MC","MC12345", true, DateTime.Now);
            
            _repository.AddTicket(car);
            _repository.AddTicket(mC);
            
            var all = _repository.GetAllTickets();
            Assert.Equal(2, all.Count);
        }

        [Fact]
            public void GetTicketsByLicenseplate_shouldReturnOnlyMatching()
            {
                var car1 = new TicketLibrary("Car","CA12345",  true, DateTime.Now);
                var car2 = new TicketLibrary("Car","CA12345",  false, DateTime.Now);
                var mC = new TicketLibrary( "MC","BX80555", true, DateTime.Now);
                //var ca12345Tickets = _repository.GetTicketsByLicenseplate ("CA12345");
                
                _repository.AddTicket(car1);
                _repository.AddTicket(car2);
                _repository.AddTicket(mC);

                var result = _repository.GetTicketsByLicenseplate("CA12345");
                Assert.Equal(2, result.Count);
                Assert.All(result, v => Assert.Equal("CA12345", v.Licenseplate));
            }
        
        }
    }

