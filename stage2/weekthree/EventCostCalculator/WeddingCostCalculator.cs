namespace EventCostCalculator;

public class WeddingCostCalculator : IEventCostCalculator
{
    public double CalculateCost(int guestAmount)
    {
        double baseVenueCost = 2000;
        double perPersonCost = 0.05 * guestAmount; // 5% is standard per guest rate for a graduation
        double eventCost = baseVenueCost + perPersonCost;
        
        return (eventCost);
    }
}