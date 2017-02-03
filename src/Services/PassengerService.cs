using System.Collections.Generic;

namespace Services
{
    public class PassengerService : IPassengerService
    {
        public IEnumerable<Passenger> GetPassengers()
        {
            return new List<Passenger> {new Passenger {Name = "James", Surname = "Brown"}};
        }
    }
}
