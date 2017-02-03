using System.Collections.Generic;

namespace Services
{
    public interface IPassengerService
    {
        IEnumerable<Passenger> GetPassengers();
    }
}