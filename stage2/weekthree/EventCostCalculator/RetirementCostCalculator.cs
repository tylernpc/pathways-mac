namespace EventCostCalculator
{
    internal class RetirementCostCalculator : IEventCostCalculator
    {
        public double CalculateCost(double totalPrice)
        {
            return (totalPrice * 0.20);
        }
    }
}
