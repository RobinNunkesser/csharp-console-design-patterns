namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for SteamedMilk.
/// </summary>
public class SteamedMilk(Beverage beverage) : CondimentDecorator
{
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Steamed Milk";
    }

    public override double Cost()
    {
        return .10 + beverage.Cost();
    }
}