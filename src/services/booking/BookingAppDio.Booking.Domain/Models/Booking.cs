using BookingAppDio.Booking.Domain.Models.ValueObjects;
using BookingAppDio.Core.ModelsAggregate;

namespace BookingAppDio.Booking.Domain.Models
{
    public class Booking : Aggregate<Guid>
    {

        public Trip Trip { get; private set; }
        public PassengerInfo PassengerInfo { get; private set; }

        public static Booking Create(Guid id, PassengerInfo passengerInfo, Trip trip, bool isDeleted = false)
        {
            var booking = new Booking()
            {
                Id = id,
                Trip = trip,
                PassengerInfo = passengerInfo,
                IsDeleted = isDeleted
            };


            return booking;
        }
    }
}
