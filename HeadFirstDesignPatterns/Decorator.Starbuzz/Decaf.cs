namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for Decaf.
/// </summary>
public class Decaf : Beverage
{
    public override double Cost()
    {
        return 1.05;
    }

    public override string GetDescription()
    {
        return "Decaf Coffee";
    }
}