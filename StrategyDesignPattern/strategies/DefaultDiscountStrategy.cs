namespace Week10.StrategyDesignPattern.strategies;

public class DefaultDiscountStrategy : IDiscountStrategy
{
    public double GetDiscount() => 1.0;
}