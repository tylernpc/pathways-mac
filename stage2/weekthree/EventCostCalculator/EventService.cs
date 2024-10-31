namespace EventCostCalculator;

public class EventService
{
    private readonly IEventCostCalculator _eventCostCalculator;

    public EventService(IEventCostCalculator eventCostCalculator)
    {
        _eventCostCalculator = eventCostCalculator;
    }

    // come back to fix this
    public void ProcessAmount(int guestAmount)
    {
        _eventCostCalculator.CalculateCost(guestAmount);
    }
}