using ClassLibrary6;

namespace StorebæltLibrary;

/// <summary>
/// 
/// </summary>
public interface ITicketRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ticket"></param>
    void AddVehicle(Vehicle ticket);
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    List<Vehicle> GetAllTickets();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="licenseplate"></param>
    /// <returns></returns>
    List<Vehicle> GetVehiclesByLicenseplate(string licenseplate); // Fixed typo and logic
}