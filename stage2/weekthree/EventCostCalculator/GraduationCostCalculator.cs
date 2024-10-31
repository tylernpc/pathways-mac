namespace EventCostCalculator;

public class GraduationCostCalculator : IEventCostCalculator
{
    public double CalculateCost(double totalPrice)
    {
        return (totalPrice * 0.20);
    }
}