using BookingAppDio.Passenger.DTOs;
using BookingAppDio.Passenger.Passengers.Models;
using BookingAppDio.Core.CQRS;
using BookingAppDio.Core.Generator;

namespace BookingAppDio.Passenger.Application.CompleteRegisterPassenger
{
    public record CompleteRegisterPassengerCommand(string PassportNumber, PassengerType PassengerType, int Age) : ICommand<PassengerResponseDto>
    {
        public long Id { get; set; } = SnowFlakeIdGenerator.NewId();
    }
}
