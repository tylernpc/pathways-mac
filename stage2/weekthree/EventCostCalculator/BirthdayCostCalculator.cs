namespace EventCostCalculator;

public class BirthdayCostCalculator : IEventCostCalculator
{
    public double CalculateCost(int guestAmount)
    {
        double baseVenueCost = 500;
        double perPersonCost = 0.15 * guestAmount; // 15% is standard per guest rate for a graduation
        double eventCost = baseVenueCost + perPersonCost;

        return (eventCost);
    }
}