using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IPassengerService
    {
        Task<IEnumerable<Passenger>> GetPassengers();
    }
}