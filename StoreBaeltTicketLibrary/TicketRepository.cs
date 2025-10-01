namespace StorebaeltLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class TicketRepository : ITicketRepository
    {
        private List<TicketLibrary> _tickets = new List<TicketLibrary>();

        /// <summary>
        /// Tilføjer en ny billet til listen over billetter.
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(TicketLibrary ticket)
        {
            _tickets.Add(ticket);
        }

        /// <summary>
        /// Returnerer en liste med alle billetter, der er gemt. 
        /// </summary>
        /// <returns></returns>
        public List<TicketLibrary> GetAllTickets()
        {
            return _tickets.ToList();
        }

        /// <summary>
        /// Finder og returnerer alle billetter, der stemmer overens med nummerpladen.
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
