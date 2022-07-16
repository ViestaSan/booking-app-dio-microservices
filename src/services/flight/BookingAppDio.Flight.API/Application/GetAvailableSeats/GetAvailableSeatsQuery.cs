using BookingAppDio.Core.CQRS;
using BookingAppDio.Flight.API.DTOs;

namespace BookingAppDio.Flight.API.Application.GetAvailableSeats
{
    public record GetAvailableSeatsQuery(long FlightId) : IQuery<IEnumerable<SeatResponseDto>>;
}
