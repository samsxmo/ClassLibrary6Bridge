
using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary6;
using StorebæltLibrary;

namespace StorebæltRepository
{
    /// <summary>
    /// 
    /// </summary>
    public class TicketRepository
    {
        private List<Vehicle> tickets = new List<Vehicle>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(Vehicle ticket)
        {
            tickets.Add(ticket);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> GetAllTickets()
        {
            return tickets;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetTotalRevenue()
        {
            return tickets.Sum(ticket => ticket.Price());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        public int GetTicketCountByType(string vehicleType)
        {
            return tickets.Count(ticket => ticket.VehicleType() == vehicleType);
        }
    }
}
 
