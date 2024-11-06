namespace EventCostCalculator;

public class RetirementCostCalculator : IEventCostCalculator
{
    public double CalculateCost(int guestAmount)
    {
        double baseVenueCost = 1500;
        double perPersonCost = 0.20 * guestAmount; // 20% is standard per guest rate for a graduation
        double eventCost = baseVenueCost + perPersonCost;
        
        return (eventCost);
    }
}