using System;

namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for Mocha.
/// </summary>
public class Mocha(Beverage beverage) : CondimentDecorator
{
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
        return size switch
        {
            BeverageSize.Tall => Convert.ToDouble(",10") + beverage.Cost(),
            BeverageSize.Grande => Convert.ToDouble(",15") + beverage.Cost(),
            BeverageSize.Venti => Convert.ToDouble(",20") + beverage.Cost(),
            _ => .20
        };
    }
}