namespace Week10.StrategyDesignPattern.strategies;

public class HalfDiscountStrategy : IDiscountStrategy
{
    public double GetDiscount() => 0.5; 
}