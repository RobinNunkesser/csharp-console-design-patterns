namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for Whip.
/// </summary>
public class Whip(Beverage beverage) : CondimentDecorator
{
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }

    public override double Cost()
    {
        return .20 + beverage.Cost();
    }
}