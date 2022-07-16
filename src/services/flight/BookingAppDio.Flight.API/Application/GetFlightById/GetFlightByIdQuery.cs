using BookingAppDio.Core.CQRS;
using BookingAppDio.Flight.API.DTOs;

namespace BookingAppDio.Flight.API.Application.GetFlightById
{
    public record GetFlightByIdQuery(long Id) : IQuery<FlightResponseDto>;
}
