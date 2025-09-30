namespace StorebæltLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class TicketRepository : ITicketRepository
    {
        private List<TicketLibrary> _tickets = new List<TicketLibrary>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(TicketLibrary ticket)
        {
            _tickets.Add(ticket);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TicketLibrary> GetAllTickets()
        {
            return _tickets.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <returns></returns>
        public List<TicketLibrary> GetTicketsByLicenseplate(string licenseplate)
        {
            return _tickets
                .Where(t => t.Licenseplate.Equals(licenseplate, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
