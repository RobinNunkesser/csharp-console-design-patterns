namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for Soy.
/// </summary>
public class Soy(Beverage beverage) : CondimentDecorator
{
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
        return .25 + beverage.Cost();
    }
}