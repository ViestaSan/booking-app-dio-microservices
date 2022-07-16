using BookingAppDio.Passenger.DTOs;
using BookingAppDio.Core.CQRS;

namespace BookingAppDio.Passenger.Application.GetPassengerById
{
    public record GetPassengerByIdQuery(long Id) : IQuery<PassengerResponseDto>;
}
