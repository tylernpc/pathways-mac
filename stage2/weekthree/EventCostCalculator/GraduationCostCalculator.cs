namespace EventCostCalculator;

public class GraduationCostCalculator : IEventCostCalculator
{
    public double CalculateCost(int guestAmount)
    {
        double baseVenueCost = 1000;
        double perPersonCost = 0.12 * guestAmount; // 12% is standard per guest rate for a graduation
        double eventCost = baseVenueCost + perPersonCost;
        
        return (eventCost);
    }
}