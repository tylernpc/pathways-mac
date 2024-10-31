namespace EventCostCalculatorMVC;

public class EventService
{
    private readonly IEventCostCalculator _eventCostCalculator;

    public EventService(IEventCostCalculator eventCostCalculator)
    {
        _eventCostCalculator = eventCostCalculator;
    }
}