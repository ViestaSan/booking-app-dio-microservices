using BookingAppDio.Passenger.Passengers.Models;

namespace BookingAppDio.Passenger.DTOs
{
    public class PassengerResponseDto
    {
        public long Id { get; init; }
        public string Name { get; init; }
        public string PassportNumber { get; init; }
        public PassengerType PassengerType { get; init; }
        public int Age { get; init; }
    }
}
