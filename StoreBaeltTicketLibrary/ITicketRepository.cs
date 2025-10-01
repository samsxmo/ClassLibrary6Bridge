using ClassLibrary6;
namespace StorebaeltLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITicketRepository
    {
        /// <summary>
        /// Tilføjer en billet
        /// </summary>
        /// <param name="ticket"></param>
        void AddTicket(TicketLibrary ticket);
        /// <summary>
        /// Henter alle billeter
        /// </summary>
        /// <returns></returns>
        List<TicketLibrary> GetAllTickets();
        /// <summary>
        /// Henter alle billeter der stemmer overens med nummerpalden. 
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <returns></returns>
        List<TicketLibrary> GetTicketsByLicenseplate(string licenseplate);
    }
}
