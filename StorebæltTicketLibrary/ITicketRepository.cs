using ClassLibrary6;
namespace StorebæltLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITicketRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ticket"></param>
        void AddTicket(TicketLibrary ticket);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<TicketLibrary> GetAllTickets();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <returns></returns>
        List<TicketLibrary> GetTicketsByLicenseplate(string licenseplate);
    }
}
