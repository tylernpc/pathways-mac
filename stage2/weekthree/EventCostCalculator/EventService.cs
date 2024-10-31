namespace EventCostCalculator;

public class EventService : IEventCostCalculator
{
    private readonly IEventCostCalculator _eventCostCalculator;

    public EventService(IEventCostCalculator eventCostCalculator)
    {
        _eventCostCalculator = eventCostCalculator;
    }

    public double CalculateCost(int guestAmount)
    {
        return _eventCostCalculator.CalculateCost(guestAmount);
    }
}