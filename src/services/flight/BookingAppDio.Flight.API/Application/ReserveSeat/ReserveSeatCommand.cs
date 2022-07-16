using BookingAppDio.Core.CQRS;
using BookingAppDio.Flight.API.DTOs;

namespace BookingAppDio.Flight.API.Application.ReserveSeat
{
    public record ReserveSeatCommand(long FlightId, string SeatNumber) : ICommand<SeatResponseDto>;
}
