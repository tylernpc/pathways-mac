namespace EventCostCalculator;

public class EventService
{
    private readonly IEventCostCalculator _eventCostCalculator;

    public EventService(IEventCostCalculator eventCostCalculator)
    {
        _eventCostCalculator = eventCostCalculator;
    }

    public void ProcessAmount(double amount)
    {
        _eventCostCalculator.CalculateCost(amount);
    }
}