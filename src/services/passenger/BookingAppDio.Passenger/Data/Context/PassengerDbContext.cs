using Microsoft.EntityFrameworkCore;

namespace BookingAppDio.Passenger.Data.Context
{
    public class PassengerDbContext : DbContext
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext> options) : base(options)
        {
        }

        public DbSet<Passengers.Models.Passenger> Passengers => Set<Passengers.Models.Passenger>();
    }
}
