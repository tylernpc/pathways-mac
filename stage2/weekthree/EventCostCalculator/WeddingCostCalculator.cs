namespace EventCostCalculator;

public class WeddingCostCalculator : IEventCostCalculator
{
    public double CalculateCost(double totalPrice)
    {
        return (totalPrice * 0.20);
    }
}