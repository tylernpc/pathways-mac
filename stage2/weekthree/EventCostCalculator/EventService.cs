namespace EventCostCalculator;

public class EventService
{
    private readonly IEventCostCalculator _eventCostCalculator;

    public EventService(IEventCostCalculator eventCostCalculator)
    {
        _eventCostCalculator = eventCostCalculator;
    }

    // uh this is never used
    // public void ProcessAmount(int guestAmount)
    // {
    //     _eventCostCalculator.CalculateCost(guestAmount);
    // }
}