//namespace StorebæltLibrary;

//public class TicketRepository
//{
    
//}

using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary6;
using StorebæltLibrary;

namespace StorebæltRepository
{
    public static class TicketRepository
    {
        // Statisk liste over alle billetter
        private static List<Vehicle> tickets = new();

        // Tilføj ny billet
        public static void AddTicket(Vehicle ticket)
        {
            tickets.Add(ticket);
        }

        // Hent alle billetter
        public static List<Vehicle> GetAllTickets()
        {
            return tickets;
        }

        // Hent billetter for en bestemt nummerplade
        public static List<Vehicle> GetTicketsByLicense(string licenseplate)
        {
            return tickets.Where(t => t.Licenseplate.Equals(licenseplate, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
