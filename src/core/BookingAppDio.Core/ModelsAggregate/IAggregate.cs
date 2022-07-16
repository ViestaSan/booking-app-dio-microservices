namespace BookingAppDio.Core.ModelsAggregate
{
    public interface IAggregate<out T> : IAggregate
    {
        T Id { get; }
    }

    public interface IAggregate
    {

    }
}
