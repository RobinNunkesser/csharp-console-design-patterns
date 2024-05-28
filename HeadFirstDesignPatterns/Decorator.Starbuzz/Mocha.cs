using System;

namespace HeadFirstDesignPatterns.Decorator.Starbuzz;

/// <summary>
///     Summary description for Mocha.
/// </summary>
public class Mocha : CondimentDecorator
{
    private readonly Beverage beverage;

    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return GetSize(Size);
    }

    private double GetSize(BeverageSize size)
    {
        switch (size)
        {
            case BeverageSize.TALL:
                return Convert.ToDouble(",10") +
                       beverage.Cost();
            case BeverageSize.GRANDE:
                return Convert.ToDouble(",15") +
                       beverage.Cost();
            case BeverageSize.VENTI:
                return Convert.ToDouble(",20") +
                       beverage.Cost();
            default:
                return .20;
        }
    }
}